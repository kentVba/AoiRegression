﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace AoiRegression
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the AoiRegressionRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
    [RepositoryFolder("048987bb-0c9c-4979-bf30-312030265387")]
    public partial class AoiRegressionRepository : RepoGenBaseFolder
    {
        static AoiRegressionRepository instance = new AoiRegressionRepository();

        /// <summary>
        /// Gets the singleton class instance representing the AoiRegressionRepository element repository.
        /// </summary>
        [RepositoryFolder("048987bb-0c9c-4979-bf30-312030265387")]
        public static AoiRegressionRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public AoiRegressionRepository() 
            : base("AoiRegressionRepository", "/", null, 0, false, "048987bb-0c9c-4979-bf30-312030265387", ".\\RepositoryImages\\AoiRegressionRepository048987bb.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("048987bb-0c9c-4979-bf30-312030265387")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
    public partial class AoiRegressionRepositoryFolders
    {
    }
#pragma warning restore 0436
}