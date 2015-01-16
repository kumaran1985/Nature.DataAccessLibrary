﻿/**
 * 自然框架之数据访问类库
 * http://www.natureFW.com/
 *
 * @author
 * 金洋（金色海洋jyk）
 * 
 * @copyright
 * Copyright (C) 2005-2013 金洋.
 *
 * Licensed under a GNU Lesser General Public License.
 * http://creativecommons.org/licenses/LGPL/2.1/
 *
 * 自然框架之数据访问类库 is free software. You are allowed to download, modify and distribute 
 * the source code in accordance with LGPL 2.1 license, however if you want to use 
 * 自然框架之数据访问类库 on your site or include it in your commercial software, you must  be registered.
 * http://www.natureFW.com/registered
 */

/* ***********************************************
 * author :  金洋（金色海洋jyk）
 * email  :  jyk0011@live.cn  
 * function: 数据访问类库的主体部分，实现基本操作。
 *           SqlClient的子类。设置参数名的前缀
 * history:  created by 金洋 
 * **********************************************
 */

namespace Nature.Data
{
    /// <summary>
    /// SqlClient的驱动方式
    /// </summary>
    class SqlClientDal : DataAccessLibrary
    {
        #region 初始化
        /// <summary>
        /// 子类的构造函数，调用父类的构造函数
        /// </summary>
        public SqlClientDal()
        {
        }

        /// <summary>
        /// 子类的构造函数，调用父类的构造函数
        /// </summary>
        /// <param name="connectionString">连接字符串</param>
        /// <param name="providerName">数据库驱动类型的名称。System.Data.SqlClient、System.Data.OleDb、System.Data.Odbc、System.Data.OracleClient 等</param>
        public SqlClientDal(string connectionString, string  providerName)
            : base(connectionString, providerName)
        {
        }
        #endregion

        

    }
}
