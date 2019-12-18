using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Test.Project.co.uk.Pages
{
    public class Homepage : BaseClass
    {
        IWebElement Customersearchproduct;
        IWebElement SubmitButton;

       

        public void Enterproduct(string product)

        {
            Customersearchproduct = GetElementById("twotabsearchtextbox");
            Customersearchproduct.SendKeys(product);
            Customersearchproduct.Click();
        }
        public SearchResultPage ClickOnSubmitButton()
        {
            SubmitButton = GetElementByClassName("nav-input");
            SubmitButton.Click();

            return new SearchResultPage();
        }

       
      
        }
          
        }
    
    






