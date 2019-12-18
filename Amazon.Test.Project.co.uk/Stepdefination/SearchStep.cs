using Amazon.Test.Project.co.uk.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Amazon.Test.Project.co.uk.Stepdefination
{
    [Binding]
    public sealed class SearchStep : BaseClass
    {
        Homepage homepage = new Homepage();
        SearchResultPage searchResultPage = new SearchResultPage();

        [Given(@"I navigate to amazon homepage")]
        public void GivenINavigateToAmazonHomepage()
        {
            LaunchUrl("https://www.amazon.co.uk/");
        }

        [When(@"I enter ""(.*)"" to searchfield")]
        public void WhenIEnterToSearchfield(string product)
        {
            homepage.Enterproduct(product);
        }

        [When(@"i click on Submitbutton")]
        public void WhenIClickOnSubmitbutton()
        {
            searchResultPage = homepage.ClickOnSubmitButton();
        }


        [Then(@"new ""(.*)"" should displayed")]
        public void ThenNewShouldDisplayed(string product)
        {
  
            }
        }

    }

