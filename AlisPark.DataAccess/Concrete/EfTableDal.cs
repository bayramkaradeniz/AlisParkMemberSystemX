﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using AlisPark.DataAccess.Abstract;
using AlisPark.Entities.Abstract;
using AlisPark.Entities.Concrete;

namespace AlisPark.DataAccess.Concrete
{
    public class EfTableDal : EfEntityRepositoryBase<Table, AlisParkContext>, ITableDal
    {
        public void CloseTable(Table table)
        {
            using (var context = new AlisParkContext())
            {
                var tableOne = context.Tables.FirstOrDefault(u => u.Id == table.Id);

                tableOne.IsOccupied = false;
                context.SaveChanges();
            }
        }

       

        public void CreateTable(string x)
        {
            using (AlisParkContext context = new AlisParkContext())
            {
                var lastTable = context.Tables.OrderByDescending(t => t.Id).FirstOrDefault();
                int newTableNumber = lastTable == null ? 1 : lastTable.TableNumber + 1;
                string newTableName = "Table-" + newTableNumber.ToString("00");

                var newTable = new Table { TableNumber = newTableNumber, TableName = newTableName, IsOccupied = false, CategoryName = x };

                context.Tables.Add(newTable);
                context.SaveChanges();
            }

        }

        public List<Table> GetStartedTables()
        {
            using (var context = new AlisParkContext())
            {
                var startedTables = context.Tables
                        .Where(x => x.IsOccupied == true)
                        .ToList();

                return startedTables;
            }
        }

        public Table GetStartedTableWithId(int tableId)
        {
            {
                using (var context = new AlisParkContext())
                {
                    var table = context.Tables.Find(tableId);
                    return table;
                }
            }
        }

        public void RemoveTable(int tableId)
        {
            using (var context = new AlisParkContext())
            {
                var table = context.Tables.SingleOrDefault(p => p.Id == tableId);

                context.Tables.Remove(table);
                context.SaveChanges();
                }
        }

        public void StartTable(Table table)
        {
            using (var context = new AlisParkContext())
            {
                Console.WriteLine("table.Id = " + table.Id);
                var tableOne = context.Tables.FirstOrDefault(u => u.Id == table.Id);
                tableOne.OpeningTime = DateTime.Now;
                tableOne.IsOccupied = true;
                context.SaveChanges();
            }
        }
    }
}
    

