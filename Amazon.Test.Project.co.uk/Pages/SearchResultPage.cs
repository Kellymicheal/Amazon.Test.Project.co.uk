using Amazon.Test.Project.co.uk.Stepdefination;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Test.Project.co.uk.Pages
{
    public class SearchResultPage : BaseClass
    {
        IWebElement pagetext;

        public void IsResultDisplayed()
        {
        pagetext =GetElementByName("a-color-state.a-text-bold");

            Assert.IsTrue(pagetext.Displayed);
        }

      
    }
}