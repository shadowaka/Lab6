using System.ComponentModel;
using Lab6.Model;
namespace Lab6.ViewModel;
class MyViewModel : INotifyPropertyChanged
{
    private string[] figure = {"Квадрат", "Треугольник"};
    private string selectedfigure;
    private double result;
    private CommandHandler clickCommand;
    private CommandHandler resetCommand;
    public string[] Figure 
    {
        get { return figure; }
        set { figure = value; }
    }
    public double Result
    {
        get
        {
            return result;
        }
        set
        {
            result = value;
            RaisePropertyChanged("Result");
        }
    }
    public string SelectedFigure
    {
        get
        {
            return selectedfigure;
        }
        set
        {
            selectedfigure = value;
            RaisePropertyChanged("SelectedFigure");
        }
    }
    public CommandHandler ClickCommand
    {
        get
        {
            return clickCommand ??
              (clickCommand = new CommandHandler(obj =>
              {
                  MyModel model = new MyModel();
                  Result = model.CalcArea(SelectedFigure);
              }));
        }
    }
    public CommandHandler ResetCommand
    {
        get
        {
            return resetCommand ??
              (resetCommand = new CommandHandler(obj =>
              {
                  Result = 0;
                  SelectedFigure = "";
                  }));
        }
    }
    public event PropertyChangedEventHandler PropertyChanged;
    protected void RaisePropertyChanged(string p)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(p));
        }
    }
}