﻿using QLCHTT.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.BUS
{
    public class BaoHanhBUS
    {
        BaoHanhDAO baoHanhDAO;
        public BaoHanhBUS()
        {
            baoHanhDAO = new BaoHanhDAO();
        }
        public DataTable getAll()
        {
            return baoHanhDAO.getAll();
        }
    }
}
