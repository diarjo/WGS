using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WGSBase;
using AppCore;
using System.Data;
using System.Collections.ObjectModel;
using System.Text;

namespace WGSMVC.Models
{
    public class BanksModel
    {
        public List<Banks> GetBank()
        {
            List<Banks> dataList = new List<Banks>();
            DataService dServ = new DataService();
            string strSql = @"SELECT
							A.BankId
                            , A.RekBank
							, A.BankName
							, A.Country
						FROM
							Banks A";
            DataTable ds = dServ.GetDataTable(strSql, "Banks");

            foreach (DataRow row in ds.Rows)
            {
                //new Banks { BankId = row[0].ToString(), BankName = row[1].ToString(), BankCountry = row[2].ToString() };
                Banks items = new Banks();
                items.BankId = row[0].ToString();
                items.RekBank = row[1].ToString();
                items.BankName = row[2].ToString();
                items.Country = row[3].ToString();
                dataList.Add(items);
            }
            return dataList;
        }

        public void GetBankDetail(Banks domain)
        {
            DataService dServ = new DataService();
            string strSql = @"SELECT
							A.BankId
                            , A.RekBank
							, A.BankName
							, A.Country
						FROM
							Banks A
                        WHERE
                            A.BankId='{0}'";
            DataTable ds = dServ.GetDataTable(string.Format(strSql, domain.BankId), "Banks");

            foreach (DataRow row in ds.Rows)
            {
                //new Banks { BankId = row[0].ToString(), BankName = row[1].ToString(), BankCountry = row[2].ToString() };
                domain.BankId = row[0].ToString();
                domain.RekBank = row[1].ToString();
                domain.BankName = row[2].ToString();
                domain.Country = row[3].ToString();
            }
            //return dataList;
        }
        
        public void InsertBank(Banks domain)
        {
            try
            {
                string COMMAND = @"
                INSERT INTO BANKS (
                    BankId
                    , RekBank
                    , BankName
                    , Country
                ) VALUES (
                    '{0}'
                    , '{1}'
                    , '{2}'
                    , '{3}'
                )";

                domain.BankId = Guid.NewGuid().ToString();
                DataService dServ = new DataService();
                dServ.exec(string.Format(COMMAND, domain.BankId, domain.RekBank, domain.BankName, domain.Country));
            }
            catch (Exception ex)
            {
            }
        }

        public void UpdateBanks(Banks domain)
        {
            try
            {
                string COMMAND = @"UPDATE Banks SET {0} WHERE BankId = '{1}' ";

                StringBuilder setValBuilder = new StringBuilder();
                setValBuilder.Append(string.Format(", RekBank = '{0}' ", domain.RekBank));
                setValBuilder.Append(string.Format(", BankName = '{0}' ", domain.BankName));
                setValBuilder.Append(string.Format(", Country = '{0}' ", domain.Country));

                DataService dServ = new DataService();
                dServ.exec(string.Format(COMMAND, setValBuilder.ToString().Substring(2), domain.BankId));
            }
            catch (Exception ex)
            {
            }
        }

        public void DeleteBanks(Banks domain)
        {
            try
            {
                string COMMAND = @"DELETE Banks WHERE BankId = '{0}' ";

                DataService dServ = new DataService();
                dServ.exec(string.Format(COMMAND,  domain.BankId));
            }
            catch (Exception ex)
            {
            }
        }
    }
}