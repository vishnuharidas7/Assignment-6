using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GridView.BAL
{
    public class Desgn_Bal
    {
        DAL.Desgn_Dal objdesgnDAL = new DAL.Desgn_Dal();
        private int _designationId;
        private string _designationName;
        private int _departmentId;

        public int Designationtid
        {
            get 
            { 
                return _designationId; 
            }
            set
            {
                _designationId = value;
            }
        }
        public string DesignationName
        {
            get
            {
                return _designationName;
            }
            set
            {
                _designationName = value;
            }
        }
        public int Departmentid
        {
            get
            {
                return _departmentId;
            }
            set
            {
                _departmentId = value; 
            }
        }

        public int insertDesignation()
        {
            return objdesgnDAL.designationInsert(this);
        }

        public DataTable viewDesgn()
        {
            return objdesgnDAL.viewDesignation();
        }

        public int updateDesgn()
        {
            return objdesgnDAL.updateDesignation(this);
        }

        public int deleteDesgn()
        {
            return objdesgnDAL.deleteDesignation(this);
        }



    }
}