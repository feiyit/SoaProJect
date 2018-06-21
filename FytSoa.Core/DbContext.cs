﻿using FytIms.Core;
using FytSoa.Core.Model.Erp;
using FytSoa.Core.Model.Sys;
using FytSoa.Extensions;
using SqlSugar;

namespace FytSoa.Core
{
    /// <summary>
    /// 数据库上下文
    /// </summary>
    public class DbContext
    {
        public DbContext()
        {
            Db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = ConfigExtensions.Configuration["DbConnection:MySqlConnectionString"],
                DbType = DbType.MySql,
                IsAutoCloseConnection = true
            });
        }
        public SqlSugarClient Db;//用来处理事务多表查询和复杂的操作

        //系统权限设置
        public DbSet<SysCode> SysCodeDb => new DbSet<SysCode>(Db);
        public DbSet<SysCodeType> SysCodeTypeDb => new DbSet<SysCodeType>(Db);
        public DbSet<SysOrganize> SysOrganizeDb => new DbSet<SysOrganize>(Db);
        public DbSet<SysImage> SysImageDb => new DbSet<SysImage>(Db);
        public DbSet<SysLog> SysLogDb => new DbSet<SysLog>(Db);
        public DbSet<SysMenu> SysMenuDb => new DbSet<SysMenu>(Db);
        public DbSet<SysPermissions> SysPermissionsDb => new DbSet<SysPermissions>(Db);
        public DbSet<SysRole> SysRoleDb => new DbSet<SysRole>(Db);
        public DbSet<SysAdmin> SysAdminDb => new DbSet<SysAdmin>(Db);
        public DbSet<SysBtnFun> SysBtnFunDb => new DbSet<SysBtnFun>(Db);

        //ERP表信息
        public DbSet<ErpBackGoods> ErpBackGoodsDb => new DbSet<ErpBackGoods>(Db);
        public DbSet<ErpGoods> ErpGoodsDb => new DbSet<ErpGoods>(Db);
        public DbSet<ErpGoodsSku> ErpGoodsSkuDb => new DbSet<ErpGoodsSku>(Db);
        public DbSet<ErpInOutLog> ErpInOutLogDb => new DbSet<ErpInOutLog>(Db);
        public DbSet<ErpPackLog> ErpPackLogDb => new DbSet<ErpPackLog>(Db);
        public DbSet<ErpReturnGoods> ErpReturnGoodsDb => new DbSet<ErpReturnGoods>(Db);
        public DbSet<ErpShopActivity> ErpShopActivityDb => new DbSet<ErpShopActivity>(Db);
        public DbSet<ErpShops> ErpShopsDb => new DbSet<ErpShops>(Db);
        public DbSet<ErpShopUser> ErpShopUserDb => new DbSet<ErpShopUser>(Db);
        public DbSet<ErpStaff> ErpStaffDb => new DbSet<ErpStaff>(Db);
        public DbSet<ErpPush> ErpPushDb => new DbSet<ErpPush>(Db);
    }
}
