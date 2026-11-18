After editing the html files, place it inside "launcher" folder.


Open config.xml and replace <DisplayMethod>BuildIn</DisplayMethod> to <DisplayMethod>Local</DisplayMethod>


If you want the html files to be server sided, replace <DisplayMethod>BuildIn</DisplayMethod> to <DisplayMethod>Remote</DisplayMethod>
then replace <HtmlPath>index.html</HtmlPath> into <HtmlPath>http://www.yourdomain.com/index.html</HtmlPath>
and <IntroHtmlPath>intro.html</IntroHtmlPath> into <IntroHtmlPath>http://www.yourdomain.com/intro.html</IntroHtmlPath>
  