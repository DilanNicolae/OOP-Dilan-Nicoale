namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            ViolatingSRPSmartPhone smartphone = new ViolatingSRPSmartPhone();
            smartphone.makeCall();
            smartphone.sendMessage();
            smartphone.takePhoto();
            smartphone.recordVideo();
            smartphone.playMusic();
            smartphone.playVideo();
            smartphone.showPictures();

            RespectSRPSmartPhone smartphone1 = new RespectSRPSmartPhone();

            smartphone1.phone.makeCall();
            smartphone1.phone.sendMessage();
            smartphone1.camera.takePhoto();
            smartphone1.camera.recordVideo();
            smartphone1.mediaPlayer.playMusic();
            smartphone1.mediaPlayer.playVideo();
            smartphone1.mediaPlayer.showPictures();


        }
    }
}
