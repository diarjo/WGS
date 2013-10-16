using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using   System.Data.Entity; 

namespace AppCore
{
	public class Banks 
	{
        //private string _BankId = string.Empty;
        //public string BankId
        //{
        //    get { return this._BankId; }
        //    set { this._BankId = value; }
        //}

        //private string _BankName = string.Empty;
        //public string BankName
        //{
        //    get { return this._BankName; }
        //    set { this._BankName = value; }
        //}

        //private string _BankCountry = string.Empty;
        //public string BankCountry
        //{
        //    get { return this._BankCountry; }
        //    set { this._BankCountry = value; }
        //}

        //private string _BankSwiftCode = string.Empty;
        //public string BankSwiftCode
        //{
        //    get { return this._BankSwiftCode; }
        //    set { this._BankSwiftCode = value; }
        //}

        //private string _StatusId = string.Empty;
        //public string StatusId
        //{
        //    get { return this._StatusId; }
        //    set { this._StatusId = value; }
        //}
        public string BankId { get; set; }
        public string RekBank { get; set; }
        public string BankName { get; set; }
        public string Country { get; set; }
	}

    public class BankDBContext :  DbContext
    {
        public DbSet<Banks> BankDB { get; set; }
    }
}
