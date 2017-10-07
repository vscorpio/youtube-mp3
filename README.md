# youtube-mp3

<h1>About</h1>
<p>Since <a href="http://youtube-mp3.org ">http://youtube-mp3.org </a>has shutdown, I started searching for an alternative, since every website I found had tons of ads and limits and many more crap, I decided to make my own program. It is based on the youtube-dl library made by rg3 (<a href="https://github.com/rg3/youtube-dl/">https://github.com/rg3/youtube-dl/</a>). The program is written in VB.net on the .NET 4.5 framework.&nbsp;</p>
<p><strong>DO</strong> not use this program for pirate use.</p>
<p>This program is still in early-alpha, expect more features soon and bug-fixes. Please report bugs at the 'issues' section.</p>
<p>The conversion speed depends on your internet bandwidth and I advise using one-at-once method over the all-at-once one.</p>
<p>The size of this software is that big due to the avconv codecs. I used avconv over ffmpeg because the size was about the same and avconv is slightly faster.</p>
<h1>Features</h1>
<p>- single URL download<br />- multiple URLs download (batch)<br />- playlist ID to video IDs resolver</p>
<h1>Usage</h1>
<p><strong>1. Single download</strong></p>
<p>Input the Youtube URL link into the &lt;youtube-url&gt; box, tick the box and then simply hit "download single.</p>
<p><strong>2. Multiple download</strong></p>
<p>a) Insert each Youtube URL link then click "<strong>Add to queue"&nbsp;</strong>then when you finished adding songs click "<strong>Download queue</strong>".</p>
<p>b) Input playlist&nbsp;<strong>ID</strong> to the corresponding textbox then hit "<strong>Add playlist to queue</strong>"</p>
<p>ex: https://www.youtube.com/playlist?list=<strong>PLuqjy0nJu_mFANPVVhioLBVK0WyEiM7OQ<br /></strong>The playlist ID is&nbsp;<strong>PLuqjy0nJu_mFANPVVhioLBVK0WyEiM7OQ</strong>.</p>
<p>&nbsp;</p>
<p><strong>MP3 files will be saved to the root directory of the executable in a folder called 'output'.</strong></p>
<h1>Binaries</h1>
<p>Windows 32/64:&nbsp;<a href="https://github.com/vscorpio/youtube-mp3/blob/master/setup.exe">https://github.com/vscorpio/youtube-mp3/blob/master/setup.exe</a></p>
<p>&nbsp;</p>
<h1>Known issues</h1>
<p>- when using all-at-once method at 20+ songs the leftover files clean-up isn't done propely (will be fixed soon)<br />- when using all-at-once method if you currently use other CPU intensive apps the conversion might not be always succesfull<br /><br /></p>
<h1>Screenshots</h1>
<p>Main UI: <br><img src="https://i.gyazo.com/2a74dc57c75547e58502beffaa427af7.gif" /> Single download: <br><img src="https://i.gyazo.com/c4e225341569e8e7fae242c3812ea0d1.gif" /></p>
