﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fritz.WebFormsTest.Web.Scenarios.Postback
{
  public partial class Textbox_StaticId : Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public TextBox TestControl {  get { return this.TestTextboxControl; } }

  }
}