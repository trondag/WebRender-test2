using System;
using WebRender4;
using WebRender4.WebRender;
using WebRender4.WebRender.Components;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            WebsiteSingleton websiteSingleton = WebsiteSingleton.getWebsiteInstance();



            //Composite

            websiteSingleton.addComponent(new HeaderBuilder().setText("overskrift")
                .setLevel(2)
                .createNewComponent());
            Component menu = new DivBuilder().createNewComponent();
            menu.addComponent(new menuItemBuilder().setText("Hjem"),
            new menyItemBuilder().setText("Våre arrangementer"),
            new menyItemBuilder().setText("Kontakt oss"));
            websiteSingleton.addComponent(menu);




          
        }
    }
}
