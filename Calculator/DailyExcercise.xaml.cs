using System;
using System.Drawing;
using Calculator.Models;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator;

public partial class DailyExcercise : ContentPage
{
    public int c=0;
    public int x = 0;
    public int y = 0;
    public int z = 0;
    private JsonSerializerOptions _serializerOptions;

    public DailyExcercise()
	{
		InitializeComponent();
	}


    public void Onclicked(object sender, EventArgs e)
    {
        c = c + 0;
        RefreshDataAsync(sender, e);
    }

    public void Onin(object sender, EventArgs e)
    {
        
        RefreshDataAsync(sender, e);
    }
    public void Onre(object sender, EventArgs e)
    {
        c = c - 2;
        RefreshDataAsync(sender, e);
    }




    public async void RefreshDataAsync(object sender, EventArgs e)
    {
         _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        var Items = new List<TodoItem>();
        var client = new HttpClient();
        Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));
        try
        {
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                c = c + 1;
                string content = await response.Content.ReadAsStringAsync();
                Items = JsonSerializer.Deserialize<List<TodoItem>>(content, _serializerOptions);
                TodoItem currentObject = new TodoItem();
                currentObject = Items[c];
                CounterBtn.Text = $"Exp {c})  {currentObject.Expression}";
                SemanticScreenReader.Announce(CounterBtn.Text);
                x = 0;
               this.RefreshDataAsync1(sender, e);
                y = 0;
               this.RefreshDataAsync2(sender, e);
                z = 0;
               this.RefreshDataAsync3(sender, e);
            }
        }
        catch (Exception ex)
       {
            Console.WriteLine(@"\tERROR {0}", ex.Message);
        }
    }

    public async void RefreshDataAsync1(object sender, EventArgs e)
    {
        y = 0;
        z = 0;
        x = x + 1;
       
        _serializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };
        var Items = new List<TodoItem>();
        var client = new HttpClient();
        Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));
        try
        {
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
      
                string content = await response.Content.ReadAsStringAsync();
                Items = JsonSerializer.Deserialize<List<TodoItem>>(content, _serializerOptions);
                TodoItem currentObject = new TodoItem();
                currentObject = Items[c];


                CounterBtn1.Text = $"1). {currentObject.Option1} ";
                SemanticScreenReader.Announce(CounterBtn1.Text);


                if (c == 0 && x != 0 || c == 4 && x != 0 || c == 5 && x != 0 || c == 7 && x != 0 || c == 9 && x != 0)
                {
                    CounterBtn1.Text = $"Right Ans";
                    SemanticScreenReader.Announce(CounterBtn1.Text);
                }
                else if (x != 0)
                {
                    CounterBtn1.Text = $"WrongAns";
                    SemanticScreenReader.Announce(CounterBtn1.Text);
                }
                
                

            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(@"\tERROR {0}", ex.Message);
        }
    }

    public async void RefreshDataAsync2(object sender, EventArgs e)

        
    {
       
        y=y+1;
        x = 0;
        z = 0;
        _serializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };
        var Items = new List<TodoItem>();
        var client = new HttpClient();
        Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));
        try
        {
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {

                string content = await response.Content.ReadAsStringAsync();
                Items = JsonSerializer.Deserialize<List<TodoItem>>(content, _serializerOptions);
                TodoItem currentObject = new TodoItem();
                currentObject = Items[c];

                CounterBtn2.Text = $"2). {currentObject.Option2}  ";

                SemanticScreenReader.Announce(CounterBtn2.Text);

                if (c == 1 && y != 0 || c == 2 && y != 0 || c == 3 && y != 0 || c == 8 && y != 0)
                {
                    CounterBtn2.Text = $"Right Ans";
                    SemanticScreenReader.Announce(CounterBtn2.Text);
                }
                else if (y != 0)
                {
                    CounterBtn2.Text = $"WrongAns";
                    SemanticScreenReader.Announce(CounterBtn2.Text);
                }
            }
                
            

        }
        catch (Exception ex)
        {
            Console.WriteLine(@"\tERROR {0}", ex.Message);
        }
    }


    public async void RefreshDataAsync3(object sender, EventArgs e)
    {
        x = 0;
        y = 0;
        z = z + 1;
      
        _serializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };
        var Items = new List<TodoItem>();
        var client = new HttpClient();
        Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));
        try
        {
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {

                string content = await response.Content.ReadAsStringAsync();
                Items = JsonSerializer.Deserialize<List<TodoItem>>(content, _serializerOptions);
                TodoItem currentObject = new TodoItem();
                currentObject = Items[c];

                CounterBtn3.Text = $"3). {currentObject.Option3} ";
                SemanticScreenReader.Announce(CounterBtn3.Text);

                if (c == 6 && z != 1 )
                {
                    CounterBtn3.Text = $"Right Ans";
                    SemanticScreenReader.Announce(CounterBtn3.Text);
                }
                else if (z != 1)
                {
                    CounterBtn3.Text = $"WrongAns";
                    SemanticScreenReader.Announce(CounterBtn3.Text);
                }


            }
            

        }
        catch (Exception ex)
        {
            Console.WriteLine(@"\tERROR {0}", ex.Message);
        }
    }





    /*
      private void OnCounterClicked1(object sender, EventArgs e)
      {

              CounterBtn.Text = $"Try Again or Skip to Next Question ";

          SemanticScreenReader.Announce(CounterBtn.Text);
      }
  */
}