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
                x = x + 1; y = y + 1; z = z + 1;
               this.RefreshDataAsync1(sender, e);
               this.RefreshDataAsync2(sender, e);
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

                x = c;
                if (x == c) {
                    CounterBtn1.Text = $"1). {currentObject.Option1} ";
                    SemanticScreenReader.Announce(CounterBtn1.Text); }

                x = x + 1;
                if (c == 0 && x==1 || c == 4 && x == 5 || c==5 && x==6 || c==7 && x==8 || c==9 && x==10 )
                {
                    CounterBtn1.Text = $"Right Ans{ x}";
                    SemanticScreenReader.Announce(CounterBtn1.Text);
                }
                else if(c==1 && x==2 || c==2 && x==3 || c==3 && x==4 || c==6 && x==7 ||c==8 && x==9)
                {
                    CounterBtn1.Text = $"WrongAns{x}";
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
                y = c;
                if (y == c)
                {
                    CounterBtn2.Text = $"2). {currentObject.Option2} ";

                    SemanticScreenReader.Announce(CounterBtn2.Text);
                }
                y = y + 1;
                if (c == 1 && y==2 || c==3 && y==4|| c==2 && y==3 || c==8 && y==9 || c == 6 && y ==7)
                {
                    CounterBtn2.Text = $"correct{y}";
                    SemanticScreenReader.Announce(CounterBtn2.Text);
                   
                }
                else if(c==2 && y==3 ||c==4 && y==5||c==5 &&y==6 || c==7&&y==8 || c==9&& y == 10)
                {
                    CounterBtn2.Text = $"WrongAns {y}";
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
                z = c;
                if (z == c)
                {
                    CounterBtn3.Text = $"3). {currentObject.Option3} ";
                    SemanticScreenReader.Announce(CounterBtn3.Text);

                }
                z = z+1;
                if (c == 4 && z==5) 
                {
                    CounterBtn3.Text = $" CorrectAns{z}";
                    SemanticScreenReader.Announce(CounterBtn3.Text);
                }
                else if(c==0&& z==1 || c==1&&z==2 || c==2&&z==3 || c==3&&z==4 || c==5&&z==6 || c==6&&z==7 ||c==7&&z==8||c==8&&z==9 ||c==9&&z==10)
                {
                    CounterBtn3.Text = $"WrongAns{z}";
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