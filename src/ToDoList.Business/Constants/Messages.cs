using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Business.Constants
{
    public static class Messages
    {
        /* Project Success Messages */
        public static string ProjectAdded = "Proje Başarıyla Eklendi !";
        public static string ProjectDeleted = "Proje Başarıyla Silindi !";
        public static string ProjectUpdated = "Proje Başarıyla Güncellendi !";
        public static string ProjectList = "Proje Başarıyla Listendi !";
        public static string ProjectGet = "Proje Başarıyla Getirildi !";
        /* END OF Project Success Messages */

        /*Project Error Messages */
        public static string ProjectAddingError = "Proje Eklenemedi !";
        public static string ProjectDeletingError = "Proje Silinemedi !";
        public static string ProjectUpdatingError = "Proje Güncellenemedi !";
        public static string ProjectGetError = "Proje Getirilemedi !";
        /* END OF Project Error Messages */

        /* Part Success Messages */
        public static string PartAdded  = "Bölüm Başarıyla Eklendi !";
        public static string PartDeleted = "Bölüm Başarıyla Silindi !";
        public static string PartUpdated= "Bölüm Başarıyla Güncellendi !";
        public static string PartList = "Bölüm Başarıyla Listelendi !";
        public static string PartGet = "Bölüm Başarıyla Getirildi !";
        /* END OF Part Success Messages */

        /* Part Error Messages */

        public static string PartGetError = "Bölüm Kimliği Geçersiz !";     
        public static string PartAddingError = "Bölüm Eklenemedi !";
        public static string PartDeletingError = "Bölüm Silinemedi !";
        public static string PartUpdatingError = "Bölüm Güncellenemedi !";
        public static string PartGetByProject = "Bu Proje Bilgilerine Ait Bir Bölüm Bulunamadı !";
        /* END OF Part Error Messages */



    }
}
