﻿//-----------------------------------------------------------------------
// <copyright file="IShutdown.cs" company="Spectrum Health">
//  Copyright (c) 2014 All Rights Reserved
//  <author>Joe Rivard</author>
// </copyright>
//-----------------------------------------------------------------------	  	  

namespace Core.Application
{
    public interface IDisposer
    {
        void Dispose(EnvironmentProfile environment);
    }
}
