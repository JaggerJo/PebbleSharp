using GalaSoft.MvvmLight;
using PebbleSharp.Net45;

namespace PebbleSharp.WPF.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IList<PebbleViewModel> _pebbleDevices;

        public MainWindowViewModel()
        {
            if ( IsInDesignMode == false )
            {
                try
                {
                    var pebbles = PebbleNet45.DetectPebbles();
                    _pebbleDevices = new List<PebbleViewModel>( pebbles.Select( x => new PebbleViewModel( x ) ) );
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    Console.WriteLine(ex.Message);
                }

            }
        }

        public IList<PebbleViewModel> PebbleDevices => _pebbleDevices;
    }
}