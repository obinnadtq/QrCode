// See https://aka.ms/new-console-template for more information
using IronQr;
using IronSoftware.Drawing;

public class Program{
    static void Main(string[] args){
        var options = new QrOptions(QrErrorCorrectionLevel.High);

        var myQr = QrWriter.Write("https://www.omoqo.com", options);
        var style = new QrStyleOptions{
            Dimensions = 300,
            Margins = 10,
            Color = Color.Black,
        };
        var qrImage = myQr.Save(style);
        qrImage.SaveAs("omoqo.png");
    }
}
