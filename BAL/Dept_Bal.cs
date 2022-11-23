using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GridView.BAL
{
    public class Dept_Bal
    {
        DAL.Dept_Dal objdepDAL = new DAL.Dept_Dal();
        private string _departmentname;
        private string _departmentid;

        public string DepartName
        {
            get
            {
                return _departmentname;
            }
            set
            {
                _departmentname = value;
            }
        }
        public string Departmentid
        {
            get
            { 
                return _departmentid;
            }
            set 
            { 
                _departmentid = value;
            }
        }

        public int insertDepartment()
        {
            return objdepDAL.departmentInsert(this);
        }

        public DataTable viewDept()
        {
            return objdepDAL.viewDepartment();
        }

        public int updateDept()
        {
            return objdepDAL.updateDepartment(this);
        }

        public int deleteUpdt()
        {
            return objdepDAL.deletedepartment(this);
        }



    }
}