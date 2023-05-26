using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

public class FuelSystemApiClient
{
    private HttpClient client;

    public FuelSystemApiClient()
    {
        client = new HttpClient();
        client.BaseAddress = new Uri("http://localhost:5000/"); // Replace with your API base URL
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public async Task<FuelSystemName> GetFuelSystemName(string id)
    {
        HttpResponseMessage response = await client.GetAsync($"api/fuelsystemnames/{id}");
        if (response.IsSuccessStatusCode)
        {
            FuelSystemName fuelSystemName = await response.Content.ReadAsAsync<FuelSystemName>();
            return fuelSystemName;
        }
        else
        {
            return null;
        }
    }

    public async Task<FuelSystemName> CreateFuelSystemName(FuelSystemName fuelSystemName)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("api/fuelsystemnames", fuelSystemName);
        response.EnsureSuccessStatusCode();

        FuelSystemName createdFuelSystemName = await response.Content.ReadAsAsync<FuelSystemName>();
        return createdFuelSystemName;
    }

    public async Task<FuelSystemName> UpdateFuelSystemName(string id, FuelSystemName fuelSystemName)
    {
        HttpResponseMessage response = await client.PutAsJsonAsync($"api/fuelsystemnames/{id}", fuelSystemName);
        response.EnsureSuccessStatusCode();

        FuelSystemName updatedFuelSystemName = await response.Content.ReadAsAsync<FuelSystemName>();
        return updatedFuelSystemName;
    }

    public async Task<bool> DeleteFuelSystemName(string id)
    {
        HttpResponseMessage response = await client.DeleteAsync($"api/fuelsystemnames/{id}");
        if (response.IsSuccessStatusCode)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
