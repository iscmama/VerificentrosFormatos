using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace VerificentrosFormatos.Data
{
    public class ParameterIn
    {
        #region Contructors

        public ParameterIn()
        {
        }
        public ParameterIn(string name, DbType dbType, object value)
        {
            _name = name;
            _dbType = dbType;
            _value = value;
        }

        #endregion Contructors

        #region Fields

        private string _name;
        private DbType _dbType;
        private object _value;

        #endregion Fields

        #region Properties

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public DbType DBType
        {
            get { return _dbType; }
            set { _dbType = value; }
        }
        public ParameterDirection ParameterDirection
        {
            get { return ParameterDirection.Input; }
        }
        public object Value
        {
            get { return _value; }
            set { _value = value; }
        }

        #endregion Properties
    }
}