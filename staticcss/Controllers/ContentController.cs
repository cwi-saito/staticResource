using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Web.UI;
using System.Drawing;
using System.Drawing.Imaging;

namespace staticcss.Controllers
{
    public class ContentController : Controller
    {
        /// <summary>
        /// ~content/css/{file}
        /// content/{file}のレスポンスを変換
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public ActionResult Css(string file)
        {
            var path = Server.MapPath("~/Content/" + file + ".css");

            // 空白除去
            //var content = string.Join("", System.IO.File.ReadAllLines(path).Select(p => p.Trim()));
            // ファイルIOエラーは良く起きるので定数で持った方が吉だと思う
            var content = "#test { color: red; }";
            
            // css形式のMINEタイプでレスポンスを返す
            return Content(content, "text/css");            
        }

        /// <summary>
        /// ~content/css/{file}
        /// content/{file}のレスポンスを変換
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public ActionResult Image(string file)
        {
            var path = Server.MapPath("~/images/");
            var bmp = new Bitmap(Path.Combine(path, file + ".png"));

            var ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Png);            
            bmp.Dispose();

            ms.Position = 0;

            return new FileStreamResult(ms, "image/png");
        }
    }
}