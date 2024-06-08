using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlisPark.Business.Abstract;
using AlisPark.DataAccess.Abstract;
using AlisPark.DataAccess.Concrete;
using AlisPark.Entities.Concrete;

namespace AlisPark.Business.Concerete
{
    public class TableManager : ITableService
    {
        private ITableDal _tableDal;

        public TableManager(ITableDal tableDal)
        {
            _tableDal = tableDal;
        }

        public List<Table> GetAll()
        {
            //Business code            
            return _tableDal.GetAll();
        }

        public List<Table> GetTableById(int tableId)
        {
            return _tableDal.GetAll(p => p.TableNumber == tableId);
        }

        public List<Table> GetTableByName(string tableName)
        {
            return _tableDal.GetAll(p => p.TableName.ToLower().Contains(tableName.ToLower()));
        }



        public void CloseTable(Table table)
        {
            _tableDal.CloseTable(new Table
            {
                Id=table.Id,
                 TableName=table.TableName,
                  IsOccupied=table.IsOccupied,
                   TableNumber=table.TableNumber,
            });
        }

        

        public void CreateTable(string x)
        {
            _tableDal.CreateTable(x);
        }

        public List<Table> GetStartedTables()
        {
            return _tableDal.GetStartedTables();
        }

        public Table GetStartedTableWithId(int tableId)
        {
            return _tableDal.GetStartedTableWithId(tableId);
        }

        public void RemoveTable(int tableId)
        {
            _tableDal.RemoveTable(tableId);
        }

        public void StartTable(Table table)
        {
            _tableDal.StartTable(table);
        }
        List<Table> ITableService.GetAll()
        {
            return _tableDal.GetAll();
        }
    }
}
