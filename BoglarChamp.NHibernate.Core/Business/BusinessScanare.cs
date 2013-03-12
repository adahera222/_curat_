using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoglarChamp.NHibernate.Core.Entity;
using log4net;
using System.Reflection;
using System.Collections;
using BoglarChamp.NHibernate.Core.DAO;


namespace BoglarChamp.NHibernate.Core
{
    internal class BusinessScanare:_BusinessBase
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public BusinessScanare()
            : base() {
            }

        internal string Scanare(string scanare)
        {
            BusinessPersoana bus = new BusinessPersoana();
            Scanare scanare1 = new Scanare();
            Scanare scn1 = null;
            string ret=null;
            string[] tmp = scanare.Split('#');


            log.Error(scanare);
            scanare1.Sef = dao.GetById(Convert.ToInt32(tmp[0]), typeof(Persoana)) as Persoana;
            scanare1.Muncitor = bus.GetMuncitorFromCod(tmp[1]);
            scanare1.Hala = dao.GetById(Convert.ToInt32(tmp[2]), typeof(Hala)) as Hala ;
            scanare1.Celula = dao.GetById(Convert.ToInt32(tmp[3]), typeof(Celula)) as Celula;
            scanare1.Ambalaj = dao.GetById(Convert.ToInt32(tmp[4]), typeof(Ambalaj)) as Ambalaj;
            scanare1.DataScanare = GetDateTimeFormat(tmp[5]);
            scanare1.Cantitate = Convert.ToInt32(tmp[6]);
            scanare1.Greutate = scanare1.Ambalaj.Greutate;

            scanare1.CheckCanSave(dao);
            scn1=dao.Save(scanare1) as Scanare;
            if (scn1.Id != 0)
            {
                //ret = scn1.Id.ToString();
                ret = SetDateTimeFormat(DateTime.Now);
            }
            

            return ret;
        }

        private string SetDateTimeFormat(DateTime dateTime)
        {
            string ret="";

            //format yyyy-MM-ddTHH:mm:ss

            try
            {
                ret = dateTime.Year.ToString() + "-" + dateTime.Month.ToString() + "-" + dateTime.Day.ToString() + "T" +
                    dateTime.Hour.ToString() + ":" + dateTime.Minute.ToString() + ":" + dateTime.Second.ToString();
                
            }
            catch
            {
                throw new Exception("Format data incorect!");
            }
            return ret;
        }

        private DateTime GetDateTimeFormat(string dataStr)
        {
            DateTime ret;

            //format yyyy-MM-ddTHH:mm:ss

            try
            {
                string[] tmp = dataStr.Split('T');
                string[] data = tmp[0].Split('-');
                string[] timp = tmp[1].Split(':');
                ret = new DateTime(Convert.ToInt32(data[0]),
                    Convert.ToInt32(data[1]),
                    Convert.ToInt32(data[2]),
                    Convert.ToInt32(timp[0]),
                    Convert.ToInt32(timp[1]),
                    Convert.ToInt32(timp[2]));
            }
            catch
            {
                throw new Exception("Format data incorect!");
            }
            return ret;
        }

        internal IList<ScanareIMO> GetScanari(string nume, string prenume, string firma,int sefId,
            DateTime dataStart, DateTime dataEnd)
        {
            IList param = new ArrayList();
            IList<Persoana> list=null;
            List<ScanareIMO> ret = null;
            string where = "";

            try
            {
                ret = new List<ScanareIMO>();
                param.Add(new QueryParameter("xDataS", dataStart.Date, "s.DataScanare", OperatorType.GreatherOrEquals, OperatorJoinType.AND));
                param.Add(new QueryParameter("xDataE", dataEnd.Date.AddDays(1).AddMilliseconds(-1), "s.DataScanare", OperatorType.LessOrEquals, OperatorJoinType.AND));
                if (nume!="")
                {
                    param.Add(new QueryParameter("xNume","%"+ nume+"%", "m.Nume", OperatorType.Like, OperatorJoinType.AND));
                }
                if (prenume!="")
                {
                    param.Add(new QueryParameter("xPrenume","%"+ prenume+"%", "m.Prenume", OperatorType.Like, OperatorJoinType.AND));
                }
                if (firma != "" && firma!="ALL")
                {
                    param.Add(new QueryParameter("yDenumireF", firma, "f.Denumire", OperatorType.Equals, OperatorJoinType.AND));
                }
                if (sefId != 0)
                {
                    param.Add(new QueryParameter("xSedId", sefId, "p.Id", OperatorType.Equals, OperatorJoinType.AND));
                }
                list = dao.ExecuteHql("select distinct m from Scanare s " +
    " inner join s.Muncitor m inner join s.Sef p inner join m.Firma f order by s.DataScanare ", param).Cast<Persoana>().ToList().AsReadOnly();

                foreach (Persoana p in list)
                {
                    ret.AddRange(GetScanareDetaliiIMO(p,dataStart,dataEnd));
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return ret;
        
    }

        private IList<ScanareIMO> GetScanareDetaliiIMO(Persoana p, DateTime dataStart, DateTime dataEnd)
        {
            IList<ScanareDetaliiIMO> list = null;
            IList<ScanareIMO> scanari = null;
            ScanareIMO scanare = null;
            DateTime dataE = new DateTime();
            DateTime dataS = new DateTime();
            try
            {
                scanari = new List<ScanareIMO>();
                
                for (DateTime date = dataStart.Date; date < dataEnd.Date.AddDays(1).AddMilliseconds(-1); date += TimeSpan.FromDays(1))
                {
                    IList param = new ArrayList();
                    dataS = date;
                    dataE = dataS.Date.AddDays(1).AddMilliseconds(-1);
                    param.Add(new QueryParameter("xDataS", date.Date, "s.DataScanare", OperatorType.GreatherOrEquals, OperatorJoinType.AND));
                    param.Add(new QueryParameter("xDataE", dataE, "s.DataScanare", OperatorType.LessOrEquals, OperatorJoinType.AND));
                    param.Add(new QueryParameter("xPId", p.Id, "m.Id", OperatorType.Equals, OperatorJoinType.AND));
                    list = dao.ExecuteHql("select new ScanareDetaliiIMO(m, s) " +
                    " from Scanare s inner join s.Muncitor m ", param).Cast<ScanareDetaliiIMO>().ToList <ScanareDetaliiIMO>().AsReadOnly();
                   
                    if (list.Count != 0)
                    {
                        scanare = new ScanareIMO();
                        scanare.Nume = p.Nume;
                        scanare.Prenume = p.Prenume;
                        scanare.DataScanare = date;
                        scanare.Detalii = list;
                        scanare.Firma = p.Firma.Denumire;
                        scanare.SefEchipa = list[0].Sef;
                        scanari.Add(scanare);
                    }
                    
                    param = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return scanari;
        }

        internal IList<RaportMuncitorIMO> GetRaportMuncitori(string nume, string prenume, DateTime dataStart, DateTime dataEnd)
        {
            IList param = new ArrayList();
            IList<Persoana> list = null;
            List<RaportMuncitorIMO> ret = null;

            try
            {
                ret = new List<RaportMuncitorIMO>();
                param.Add(new QueryParameter("xDataS", dataStart.Date, "s.DataScanare", OperatorType.GreatherOrEquals, OperatorJoinType.AND));
                param.Add(new QueryParameter("xDataE", dataEnd.Date.AddDays(1).AddMilliseconds(-1), "s.DataScanare", OperatorType.LessOrEquals, OperatorJoinType.AND));
                if (nume != "")
                {
                    param.Add(new QueryParameter("xNume","%"+ nume+"%", "m.Nume", OperatorType.Like, OperatorJoinType.AND));
                }
                if (prenume != "")
                {
                    param.Add(new QueryParameter("xPrenume","%"+ prenume+"%", "m.Prenume", OperatorType.Like, OperatorJoinType.AND));
                }
                list = dao.ExecuteHql("select distinct m from Scanare s " +
    " inner join s.Muncitor m order by s.DataScanare", param).Cast<Persoana>().ToList().AsReadOnly();

                foreach (Persoana p in list)
                {
                    ret.Add(GetRaportDetaliiMuncitor(p, dataStart, dataEnd));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }

        private RaportMuncitorIMO GetRaportDetaliiMuncitor(Persoana p, DateTime dataStart, DateTime dataEnd)
        {
            IList<RaportDetaliiMuncitorIMO> list = null;
            RaportDataIMO dataScanare = null;
            RaportMuncitorIMO ret = null;
            decimal totalGreutate = 0;
            decimal totalGreutatePerioada = 0;
            DateTime dataE = new DateTime();
            DateTime dataS = new DateTime();
            try
            {


                ret = new RaportMuncitorIMO();
                for (DateTime date = dataStart.Date; date < dataEnd.Date.AddDays(1).AddMilliseconds(-1); date += TimeSpan.FromDays(1))
                {
                    IList param = new ArrayList();
                    dataS = date;
                    dataE = dataS.Date.AddDays(1).AddMilliseconds(-1);
                    param.Add(new QueryParameter("xDataS", date.Date, "s.DataScanare", OperatorType.GreatherOrEquals, OperatorJoinType.AND));
                    param.Add(new QueryParameter("xDataE", dataE, "s.DataScanare", OperatorType.LessOrEquals, OperatorJoinType.AND));
                    param.Add(new QueryParameter("xPId", p.Id, "m.Id", OperatorType.Equals, OperatorJoinType.AND));
                    list = dao.ExecuteHql("select new RaportDetaliiMuncitorIMO(s.DataScanare,count(s.Id),sum(a.Greutate),a.Denumire) " +
                    " from Scanare s inner join s.Muncitor m inner join s.Ambalaj a group by a.Denumire", param).Cast<RaportDetaliiMuncitorIMO>().ToList().AsReadOnly();

                    if (list.Count != 0)
                    {
                        ret.persoana = p;
                        ret.Numar = p.Numar;
                        dataScanare = new RaportDataIMO(date);
                        foreach (RaportDetaliiMuncitorIMO det in list)
                        {
                            dataScanare.Detalii.Add(det);
                            totalGreutate += det.Greutate;
                        }
                        dataScanare.TotalGreutateZi = totalGreutate;
                        totalGreutatePerioada += totalGreutate;
                        ret.DataScanare.Add(dataScanare);
                    }
                    ret.TotalGreutatePerioada = totalGreutatePerioada;
                    param = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }

        internal IList<RaportMuncitorIMO> GetRaportTotalMuncitori(DateTime dataStart, DateTime dataEnd)
        {
            IList param = new ArrayList();
            IList<Persoana> list = null;
            List<RaportMuncitorIMO> ret = null;

            try
            {
                ret = new List<RaportMuncitorIMO>();
                param.Add(new QueryParameter("xDataS", dataStart.Date, "s.DataScanare", OperatorType.GreatherOrEquals, OperatorJoinType.AND));
                param.Add(new QueryParameter("xDataE", dataEnd.Date.AddDays(1).AddMilliseconds(-1), "s.DataScanare", OperatorType.LessOrEquals, OperatorJoinType.AND));
                
                list = dao.ExecuteHql("select distinct m from Scanare s " +
    " inner join s.Muncitor m order by s.DataScanare", param).Cast<Persoana>().ToList().AsReadOnly();

                foreach (Persoana p in list)
                {
                    ret.Add(GetRaportTotalDetaliiMuncitor(p, dataStart, dataEnd));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }

        private RaportMuncitorIMO GetRaportTotalDetaliiMuncitor(Persoana p, DateTime dataStart, DateTime dataEnd)
        {
            IList<RaportDetaliiMuncitorIMO> list = null;
            RaportDataIMO dataScanare = null;
            RaportMuncitorIMO ret = null;
            decimal totalGreutate = 0;
            decimal totalGreutatePerioada = 0;
            
            try
            {


                ret = new RaportMuncitorIMO();
               
                    IList param = new ArrayList();
                    param.Add(new QueryParameter("xDataS", dataStart.Date, "s.DataScanare", OperatorType.GreatherOrEquals, OperatorJoinType.AND));
                    param.Add(new QueryParameter("xDataE", dataEnd.Date.AddDays(1).AddMilliseconds(-1), "s.DataScanare", OperatorType.LessOrEquals, OperatorJoinType.AND));
                    param.Add(new QueryParameter("xPId", p.Id, "m.Id", OperatorType.Equals, OperatorJoinType.AND));
                    list = dao.ExecuteHql("select new RaportDetaliiMuncitorIMO(count(s.Id),sum(a.Greutate),a.Denumire) " +
                    " from Scanare s inner join s.Muncitor m inner join s.Ambalaj a group by a.Denumire", param).Cast<RaportDetaliiMuncitorIMO>().ToList().AsReadOnly();

                    if (list.Count != 0)
                    {
                        ret.persoana = p;
                        ret.Numar = p.Numar;
                        ret.DataStart = dataStart;
                        ret.DataEnd = dataEnd;
                        dataScanare = new RaportDataIMO(dataStart);
                        foreach (RaportDetaliiMuncitorIMO det in list)
                        {
                            dataScanare.Detalii.Add(det);
                            totalGreutate += det.Greutate;
                        }
                        dataScanare.TotalGreutateZi = totalGreutate;
                        totalGreutatePerioada += totalGreutate;
                        ret.DataScanare.Add(dataScanare);
                    }
                    ret.TotalGreutatePerioada = totalGreutatePerioada;

                    param = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }

        internal IList<ScanareIMO> GetScanariAmbalaje(string firma,string ambalaj, DateTime dataStart, DateTime dataEnd)
        {
            List<ScanareIMO> ret = null;
            IList<ScanareDetaliiIMO> listDetalii=null;
            DateTime dataE = new DateTime();
            DateTime dataS = new DateTime();
            ScanareIMO scanare=null;
            decimal totalGreutateZi = 0;

            try
            {
                ret = new List<ScanareIMO>();

                for (DateTime date = dataStart.Date; date < dataEnd.Date.AddDays(1).AddMilliseconds(-1); date += TimeSpan.FromDays(1))
                {
                    IList param = new ArrayList();
                    dataS = date;
                    dataE = dataS.Date.AddDays(1).AddMilliseconds(-1);
                    param.Add(new QueryParameter("xDataS", date.Date, "s.DataScanare", OperatorType.GreatherOrEquals, OperatorJoinType.AND));
                    param.Add(new QueryParameter("xDataE", dataE, "s.DataScanare", OperatorType.LessOrEquals, OperatorJoinType.AND));
                    if (ambalaj != "" && ambalaj != "ALL")
                    {
                        param.Add(new QueryParameter("xDenumireA", ambalaj, "a.Denumire", OperatorType.Equals, OperatorJoinType.AND));
                    }
                    if (firma != "" && firma != "ALL")
                    {
                        param.Add(new QueryParameter("yDenumireF", firma, "f.Denumire", OperatorType.Equals, OperatorJoinType.AND));
                    }

                    listDetalii = dao.ExecuteHql("select new ScanareDetaliiIMO(a,count(s.Id),sum(a.Greutate)) " +
                    " from Scanare s inner join s.Muncitor m inner join m.Firma f "+
                    " inner join s.Ambalaj a group by a.Denumire",
                    param).Cast<ScanareDetaliiIMO>().ToList<ScanareDetaliiIMO>().AsReadOnly();
                    if (listDetalii.Count != 0)
                    {
                        scanare = new ScanareIMO();
                        scanare.DataScanare = date;
                        scanare.DataStart = dataStart;
                        scanare.DataEnd = dataEnd;
                        scanare.Firma = firma;
                        totalGreutateZi = 0;
                        foreach (ScanareDetaliiIMO det in listDetalii)
                        {
                            scanare.Detalii.Add(det);
                            totalGreutateZi += det.Greutate;
                        }
                        scanare.TotalGreutateZi = totalGreutateZi;
                        ret.Add(scanare);
                    }
                    param = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }

        internal IList<RaportCumulatMuncitorIMO> GetRaportSefEchipa(int firmaId,int sefId, DateTime dataStart, DateTime dataEnd)
        {
            IList param = new ArrayList();
            IList<Persoana> list = null;
            List<RaportCumulatMuncitorIMO> ret = null;

            try
            {
                ret = new List<RaportCumulatMuncitorIMO>();
                param.Add(new QueryParameter("xDataS", dataStart.Date, "s.DataScanare", OperatorType.GreatherOrEquals, OperatorJoinType.AND));
                param.Add(new QueryParameter("xDataE", dataEnd.Date.AddDays(1).AddMilliseconds(-1), "s.DataScanare", OperatorType.LessOrEquals, OperatorJoinType.AND));
                if (sefId != 0)
                {
                    param.Add(new QueryParameter("xSefId", sefId, "p.Id", OperatorType.Equals, OperatorJoinType.AND));
                }
                list = dao.ExecuteHql("select distinct p from Scanare s " +
    " inner join s.Sef p order by s.DataScanare", param).Cast<Persoana>().ToList().AsReadOnly();

                foreach (Persoana p in list)
                {
                    ret.AddRange(GetRaportSefEchipaDetalii(firmaId,p, dataStart, dataEnd));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }

        private IList<RaportCumulatMuncitorIMO> GetRaportSefEchipaDetalii(int firmaId,Persoana p, DateTime dataStart, DateTime dataEnd)
        {
            List<RaportCumulatMuncitorIMO> ret = null;
            IList<RaportCumulatMuncitorIMO> list = null;
            DateTime dataE = new DateTime();
            DateTime dataS = new DateTime();
            decimal totalGreutateZi;

            try
            {
                ret = new List<RaportCumulatMuncitorIMO>();

                for (DateTime date = dataStart.Date; date < dataEnd.Date.AddDays(1).AddMilliseconds(-1); date += TimeSpan.FromDays(1))
                {
                    IList param = new ArrayList();
                    dataS = date;
                    dataE = dataS.Date.AddDays(1).AddMilliseconds(-1);
                    param.Add(new QueryParameter("xDataS", date.Date, "s.DataScanare", OperatorType.GreatherOrEquals, OperatorJoinType.AND));
                    param.Add(new QueryParameter("xDataE", dataE, "s.DataScanare", OperatorType.LessOrEquals, OperatorJoinType.AND));
                    param.Add(new QueryParameter("xSefId", p.Id, "m.Id", OperatorType.Equals, OperatorJoinType.AND));
                    param.Add(new QueryParameter("xFirmaId", firmaId, "f.Id", OperatorType.Equals, OperatorJoinType.AND));

                    list = dao.ExecuteHql("select new RaportCumulatMuncitorIMO(s,a,count(s.Id),sum(a.Greutate)) " +
                    " from Scanare s inner join s.Sef m inner join m.Firma f " +
                    " inner join s.Ambalaj a group by a.Denumire",
                    param).Cast<RaportCumulatMuncitorIMO>().ToList<RaportCumulatMuncitorIMO>().AsReadOnly();
                    if (list.Count != 0)
                    {
                        totalGreutateZi = 0;
                        foreach (RaportCumulatMuncitorIMO det in list)
                        {
                            totalGreutateZi += det.Greutate;
                            det.TotalGreutateZi=totalGreutateZi;
                            det.DataStart = dataStart;
                            det.DataEnd = dataEnd;
                        }
                        ret.AddRange(list);
                    }
                    param = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }

        internal IList<RaportCumulatMuncitorIMO> GetRaportSefiEchipa(int firmaId, int sefId, DateTime dataStart, DateTime dataEnd)
        {
            IList param = new ArrayList();
            IList<Persoana> list = null;
            List<RaportCumulatMuncitorIMO> ret = null;

            try
            {
                ret = new List<RaportCumulatMuncitorIMO>();
                param.Add(new QueryParameter("xDataS", dataStart.Date, "s.DataScanare", OperatorType.GreatherOrEquals, OperatorJoinType.AND));
                param.Add(new QueryParameter("xDataE", dataEnd.Date.AddDays(1).AddMilliseconds(-1), "s.DataScanare", OperatorType.LessOrEquals, OperatorJoinType.AND));
                
                list = dao.ExecuteHql("select distinct p from Scanare s " +
    " inner join s.Sef p order by s.DataScanare", param).Cast<Persoana>().ToList().AsReadOnly();

                foreach (Persoana p in list)
                {
                    ret.AddRange(GetRaportSefiEchipaDetalii(firmaId, p, dataStart, dataEnd));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }

        private IList<RaportCumulatMuncitorIMO> GetRaportSefiEchipaDetalii(int firmaId, Persoana p, DateTime dataStart, DateTime dataEnd)
        {
            List<RaportCumulatMuncitorIMO> ret = null;
            IList<RaportCumulatMuncitorIMO> list = null;
            //DateTime dataE = new DateTime();
            //DateTime dataS = new DateTime();
            decimal totalGreutateZi;

            try
            {
                ret = new List<RaportCumulatMuncitorIMO>();

                //for (DateTime date = dataStart.Date; date < dataEnd.Date.AddDays(1).AddMilliseconds(-1); date += TimeSpan.FromDays(1))
                //{
                    IList param = new ArrayList();
                    //dataS = date;
                    //dataE = dataS.Date.AddDays(1).AddMilliseconds(-1);
                    param.Add(new QueryParameter("xDataS", dataStart.Date, "s.DataScanare", OperatorType.GreatherOrEquals, OperatorJoinType.AND));
                    param.Add(new QueryParameter("xDataE", dataEnd.Date.AddDays(1).AddMilliseconds(-1), "s.DataScanare", OperatorType.LessOrEquals, OperatorJoinType.AND));
                    param.Add(new QueryParameter("xSefId", p.Id, "m.Id", OperatorType.Equals, OperatorJoinType.AND));
                    param.Add(new QueryParameter("xFirmaId", firmaId, "f.Id", OperatorType.Equals, OperatorJoinType.AND));

                    list = dao.ExecuteHql("select new RaportCumulatMuncitorIMO(s,a,count(s.Id),sum(a.Greutate)) " +
                    " from Scanare s inner join s.Sef m inner join m.Firma f " +
                    " inner join s.Ambalaj a group by a.Denumire",
                    param).Cast<RaportCumulatMuncitorIMO>().ToList<RaportCumulatMuncitorIMO>().AsReadOnly();
                    if (list.Count != 0)
                    {
                        totalGreutateZi = 0;
                        foreach (RaportCumulatMuncitorIMO det in list)
                        {
                            totalGreutateZi += det.Greutate;
                            det.TotalGreutatePerioada = totalGreutateZi;
                            det.DataEnd = dataEnd;
                            det.DataStart = dataStart;
                        }
                        ret.AddRange(list);
                    }
                    param = null;
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }
    }
}
