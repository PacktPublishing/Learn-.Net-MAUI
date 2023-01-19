﻿using ForgetMeNotDemo.View;
using ForgetMeNotDemo.ViewModel;

namespace ForgetMeNotDemo;

public partial class App : Application
{


  public App(LoginViewModel loginViewModel)
  {
    InitializeComponent();

    //MainPage = new AppShell();

    MainPage = new LoginPage(loginViewModel);

  }

}
