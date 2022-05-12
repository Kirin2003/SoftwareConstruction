﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCrawler {
  class SimpleCrawler {
        
    private Hashtable urls = new Hashtable();
    private int count = 0;
        private Uri initUri;
        private List<String> crawledUrl = new List<String>();
        private List<String> wrongUrl = new List<String>();

    static void Main(string[] args) {


            string startUrl = "http://www.cnblogs.com/dstang2000/";

            SimpleCrawler myCrawler = new SimpleCrawler(startUrl);


            myCrawler.urls.Add(startUrl, false);//加入初始页面
            Thread t = new Thread(myCrawler.Crawl);
            t.Start();
        }

        public SimpleCrawler(string initUri)
        {
            this.initUri = new Uri(initUri); 
        }


        

    private void Crawl() {
            //开始爬行
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;

                    // 在指定网站爬行          
                    if (!url.Contains(initUri.Host))
                    {
                        wrongUrl.Add(url);
                        continue;
                    }
                    current = url;


                    if (current == null || count > 10) break;                   

                    string html = DownLoad(current);    // 下载

                    crawledUrl.Add(current); // 已经爬取过的url
                    urls[current] = true;
                    count++;
                    Parse(html,current);//解析,并加入新的链接
                    // 爬行结束
                    break;
                }
            }
    }

    public string DownLoad(string url) {
      
        WebClient webClient = new WebClient();
        webClient.Encoding = Encoding.UTF8;
        string html = webClient.DownloadString(url);
        string fileName = count.ToString();
        File.WriteAllText(fileName, html, Encoding.UTF8); // 下载地址：filename
        return html;
      
     
    }

    private void Parse(string html,string current) {
      string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
      MatchCollection matches = new Regex(strRef).Matches(html);
      foreach (Match match in matches) {
            strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                  .Trim('"', '\"', '#', '>');
            if (strRef.Length == 0) continue;


            
                // 只有当爬取的是html/htm/aspx/jsp/php等网页，才解析并爬取下一级url
            if (new Regex("(html|htm|aspx|jsp|php)").IsMatch(strRef) && urls[strRef] == null)
            {
                    // 相对路径转绝对路径
                Uri currentUri  = new Uri(current);
                    Uri newUri = new Uri(currentUri, strRef);
                urls[newUri.ToString()] = false;
            }
                
      }
    }

        
  }
}
