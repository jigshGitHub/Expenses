﻿using System;
using System.Data.Entity.ModelConfiguration;

namespace Expenses.Model
{
    public class Expense : EntityTypeConfiguration<Expense>
    {   
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public byte[] Image { get; set; }

        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }

        public ExpenseReport ExpenseReport { get; set; }
        
        public Employee Employee { get; set; }

        public int TypeId { get; set; }
        public ExpenseType Type { get; set; }

    }
}
