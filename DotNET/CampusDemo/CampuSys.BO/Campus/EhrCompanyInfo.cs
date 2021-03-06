using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CampuSys.Core.Text;


namespace CampuSys.BO.Campus
{
    public class EhrCompanyInfo
    {
   
        private decimal _mem_id = 0;
        private string _mem_name = String.Empty;
        private string _mem_abbr = String.Empty;
        private string _licence_no = String.Empty;
        private short _type_id = 0;
        private short _size_id = 0;
        private short _loc_id = 0;
        private string _address = String.Empty;
        private string _zipcode = String.Empty;
        private string _mem_url = String.Empty;
        private byte _email_type;
        private string _linkman_name = String.Empty;
        private string _linkman_title = String.Empty;
        private byte _linkman_gender;
        private string _email = String.Empty;
        private string _telephone = String.Empty;
        private string _fax = String.Empty;
        private string _intro = String.Empty;
        private int _ind_id1 = 0;
        private int _ind_id2 = 0;
        private int _ind_id3 = 0;
        private DateTime _reg_date;
        private string _reg_ip = String.Empty;
        private DateTime _last_update_date;
        private int _last_login_user = 0;
        private DateTime _last_search;
        private DateTime _last_login_date;
        private int _login_count = 0;
        private int _job_option = 0;
        private string _savecv_table = String.Empty;
        private string _apply_form = String.Empty;
        private string _logo = String.Empty;
        private int _job_quota = 0;
        private int _job_offlinedays = 0;
      
      
        public decimal mem_id
        {
            get { return _mem_id; }
            set { _mem_id = value; }
        }

        public string mem_name
        {
            get { return _mem_name; }
            set { _mem_name = value; }
        }

        public string mem_abbr
        {
            get { return _mem_abbr; }
            set { _mem_abbr = value; }
        }

        public string licence_no
        {
            get { return _licence_no; }
            set { _licence_no = value; }
        }

        public short type_id
        {
            get { return _type_id; }
            set { _type_id = value; }
        }

        public short size_id
        {
            get { return _size_id; }
            set { _size_id = value; }
        }

        public short loc_id
        {
            get { return _loc_id; }
            set { _loc_id = value; }
        }

        public string address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string zipcode
        {
            get { return _zipcode; }
            set { _zipcode = value; }
        }

        public string mem_url
        {
            get { return _mem_url; }
            set { _mem_url = value; }
        }

        public byte email_type
        {
            get { return _email_type; }
            set { _email_type = value; }
        }

        public string linkman_name
        {
            get { return _linkman_name; }
            set { _linkman_name = value; }
        }

        public string linkman_title
        {
            get { return _linkman_title; }
            set { _linkman_title = value; }
        }

        public byte linkman_gender
        {
            get { return _linkman_gender; }
            set { _linkman_gender = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }

        public string fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        public string intro
        {
            get { return _intro; }
            set { _intro = value; }
        }

        public int ind_id1
        {
            get { return _ind_id1; }
            set { _ind_id1 = value; }
        }

        public int ind_id2
        {
            get { return _ind_id2; }
            set { _ind_id2 = value; }
        }

        public int ind_id3
        {
            get { return _ind_id3; }
            set { _ind_id3 = value; }
        }

        public DateTime reg_date
        {
            get { return _reg_date; }
            set { _reg_date = value; }
        }

        public string reg_ip
        {
            get { return _reg_ip; }
            set { _reg_ip = value; }
        }

        public DateTime last_update_date
        {
            get { return _last_update_date; }
            set { _last_update_date = value; }
        }

        public int last_login_user
        {
            get { return _last_login_user; }
            set { _last_login_user = value; }
        }

        public DateTime last_search
        {
            get { return _last_search; }
            set { _last_search = value; }
        }

        public DateTime last_login_date
        {
            get { return _last_login_date; }
            set { _last_login_date = value; }
        }

        public int login_count
        {
            get { return _login_count; }
            set { _login_count = value; }
        }

        public int job_option
        {
            get { return _job_option; }
            set { _job_option = value; }
        }

        public string savecv_table
        {
            get { return _savecv_table; }
            set { _savecv_table = value; }
        }

        public string apply_form
        {
            get { return _apply_form; }
            set { _apply_form = value; }
        }

        public string logo
        {
            get { return _logo; }
            set { _logo = value; }
        }

        public int job_quota
        {
            get { return _job_quota; }
            set { _job_quota = value; }
        }

        public int job_offlinedays
        {
            get { return _job_offlinedays; }
            set { _job_offlinedays = value; }
        }
      
        public EhrCompanyInfo() { }

        public EhrCompanyInfo(DataRow dr)
        {
            try
            {
                if (dr != null)
                {
                    _mem_id = Convert.ToDecimal( CommonText.IsNull(dr["mem_id"].ToString(),"0") );
                    _mem_name = Convert.ToString(   CommonText.IsNull(dr["mem_name"].ToString(),"") );
                    _mem_abbr = Convert.ToString(   CommonText.IsNull(dr["mem_abbr"].ToString(),"") );
                    _licence_no = Convert.ToString(  CommonText.IsNull(dr["licence_no"].ToString(),""));
                    _type_id = Convert.ToInt16( CommonText.IsNull(dr["type_id"].ToString(),"0")  );
                    _size_id = Convert.ToInt16(CommonText.IsNull(dr["size_id"].ToString(),"0") );
                    _loc_id = Convert.ToInt16(CommonText.IsNull(dr["loc_id"].ToString(),"0") );

                    _address = Convert.ToString( CommonText.IsNull(dr["address"].ToString(),"")   );
                    _zipcode = Convert.ToString(CommonText.IsNull(dr["zipcode"].ToString(),"")  );
                    _mem_url = Convert.ToString( CommonText.IsNull(dr["mem_url"].ToString(),"")   );
                    _email_type = Convert.ToByte( CommonText.IsNull(dr["email_type"].ToString(),"0")   );
                    _linkman_name = Convert.ToString(CommonText.IsNull(dr["linkman_name"].ToString(),"")   );
                    _linkman_title = Convert.ToString(CommonText.IsNull(dr["linkman_title"].ToString(),"") );
                    _linkman_gender = Convert.ToByte(   CommonText.IsNull(dr["linkman_gender"].ToString(),"0")    );
                    _email = Convert.ToString( CommonText.IsNull(dr["email"].ToString(),"") );
                    _telephone = Convert.ToString(CommonText.IsNull(dr["telephone"].ToString(),"")     );
                    _fax = Convert.ToString(CommonText.IsNull(dr["fax"].ToString(),"")    );
                    _intro = Convert.ToString(   CommonText.IsNull(dr["intro"].ToString(),"")  );
                    _ind_id1 = Convert.ToInt32( CommonText.IsNull(dr["ind_id1"].ToString(),"0")   );
                    _ind_id2 = Convert.ToInt32( CommonText.IsNull(dr["ind_id2"].ToString(),"0"));
                    _ind_id3 = Convert.ToInt32(CommonText.IsNull(dr["ind_id3"].ToString(),"0")  );
                    _reg_date = Convert.ToDateTime(  CommonText.IsNull(dr["reg_date"].ToString(),DateTime.Now.ToString()) ) ;
                    _reg_ip = Convert.ToString(CommonText.IsNull(dr["reg_ip"].ToString(),"0")   );
                    _last_update_date = Convert.ToDateTime(    CommonText.IsNull(dr["last_update_date"].ToString(),DateTime.Now.ToString()) );
                    _last_login_user = Convert.ToInt32( CommonText.IsNull(dr["last_login_user"].ToString(),"0") );
                    _last_search = Convert.ToDateTime( CommonText.IsNull(dr["last_search"].ToString(),DateTime.Now.ToString())  );
                    _last_login_date = Convert.ToDateTime(  CommonText.IsNull(dr["last_login_date"].ToString(),DateTime.Now.ToString()) );
                    _login_count = Convert.ToInt32(    CommonText.IsNull(dr["login_count"].ToString(),"0")      );
                    _job_option = Convert.ToInt32(    CommonText.IsNull(dr["job_option"].ToString(),"0")  );
                    _savecv_table = Convert.ToString(CommonText.IsNull(dr["savecv_table"].ToString(),"")     );
                    _apply_form = Convert.ToString(CommonText.IsNull(dr["apply_form"].ToString(),"")     );
                    _logo = Convert.ToString(CommonText.IsNull(dr["logo"].ToString(),"")     );
                    _job_quota = Convert.ToInt32(    CommonText.IsNull(dr["job_quota"].ToString(),"0") );
                    _job_offlinedays = Convert.ToInt32( CommonText.IsNull(dr["job_offlinedays"].ToString(),"0") );
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }


     
    }
}
