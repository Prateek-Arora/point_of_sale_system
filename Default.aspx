<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <section class="section-features" id ="home_page">
        <div class="rows">
            <div class="main-text-box">
                <h1>Point Of Sale.</h1>
                <a class="btn btn-main" href="login_page.aspx">I'm ready</a>
                <a class="btn btn-sec" href="#about_us">Show me more</a>
          </div>
        </div>
    </section>

    <section class="section-features clearfix" id ="about_us">
      <div class="rows">
        <h2>Who Are We?</h2>
        <p class="long-text" >We here at POS systems ensure that you are delivered the worth of your time and resources.</p>
      </div>

      <div class="rows">
        <div class="col span-1-of-3 box">
          <i class="icon ion-md-cube icon-big"></i>
          <h3>We Connect</h3>
          <p>POS systems helps build a huge network around the globe so that our loyal customers and clients can enjoy our services even at the most remote places thus making us all a big family thus enhancing your experience.</p>
        </div>
      </div>

      <div class="rows">
        <div class="col span-1-of-3 box">
          <i class="icon ion-md-heart icon-big"></i>
          <h3>We Care</h3>
          <p>POS systems is actively involved in serving not just our customers but also many NGOs and is a part of many social activities around the globe thus serving the humankind to the best of our duties.</p>
        </div>
      </div>

      <div class="rows">
        <div class="col span-1-of-3 box">
          <i class="icon ion-md-mail icon-big"></i>
          <h3>Reach Out to Us</h3>
          <p>We have an active service sector that are 24/7 ready to help you out whenever you feel lost with our product and thus leaving no room for any complaints by supporting you to the best of our abilities.</p>
        </div>
      </div>
    </section>

    <section class="section-step clearfix" id="help" >
        <div class="rows">
          <h2>How it works.</h2>
        </div>
        <div class="rows">
            <div class="col span-1-of-2 steps-box">
              <img src="resources/css/img/pos_machine.png" alt="machine" class="app-screen">
            </div>
            <div class="col span-1-of-2 steps-box">
              <div class="work-step">
                <div>
                  1
                </div>
                <p>First register as a Cashier and then login to access the shop centre.</p>
              </div>

              <div class="work-step">
                <div>
                  2
                </div>
                <p>Choose any of the four categories and select the items the customer wants to purchase by adding the items to the cart.</p>
              </div>

              <div class="work-step">
                <div>
                  3
                </div>
                <p>Click at "Buy Now" button to generate a bill or go back to change the quantities of the selected items or to add more new ones.</p>
              </div>
            </div>
        </div>
    </section>

    
</asp:Content>