// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prism.IocContainer.Tests.Support
{
    public class BootstrapperFixtureBase
    {
        protected static void AssertExceptionThrownOnRun(Bootstrapper bootstrapper, Type expectedExceptionType, string expectedExceptionMessageSubstring)
        {
            bool exceptionThrown = false;
            try
            {
                bootstrapper.Run();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expectedExceptionType, ex.GetType());
                StringAssert.Contains(ex.Message, expectedExceptionMessageSubstring);
                exceptionThrown = true;
            }

            if (!exceptionThrown)
            {
                Assert.Fail("Exception not thrown.");
            }
        }
    }
}