﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudBread.Models
{
    public class ComSelCouponInputParams
    {
        public string MemberID { get; set; }     // log purpose
        public string CouponID { get; set; }
        public string token { get; set; }
    }

    public class ComSelCouponModel
    {
        public string CouponID { get; set; }
        public string CouponCategory1 { get; set; }
        public string CouponCategory2 { get; set; }
        public string CouponCategory3 { get; set; }
        public string ItemListID { get; set; }
        public string ItemCount { get; set; }
        public string ItemStatus { get; set; }
        public string TargetGroup { get; set; }
        public string TargetOS { get; set; }
        public string TargetDevice { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string sCol1 { get; set; }
        public string sCol2 { get; set; }
        public string sCol3 { get; set; }
        public string sCol4 { get; set; }
        public string sCol5 { get; set; }
        public string sCol6 { get; set; }
        public string sCol7 { get; set; }
        public string sCol8 { get; set; }
        public string sCol9 { get; set; }
        public string sCol10 { get; set; }
    }
}