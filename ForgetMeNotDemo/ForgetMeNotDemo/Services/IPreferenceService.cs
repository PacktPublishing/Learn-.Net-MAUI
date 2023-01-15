﻿using ForgetMeNotDemo.Model;

namespace ForgetMeNotDemo.Services;

public interface IPreferenceService
{
  public Task<List<Preference>> GetPreferences();
  public Task<List<Preference>> GetPreferencesMock();
}