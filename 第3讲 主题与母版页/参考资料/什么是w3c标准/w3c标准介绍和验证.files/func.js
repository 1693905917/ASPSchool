var imgwidth=700;
function $(id){return document.getElementById(id);}
function show(o){document.getElementById(o).style.display="block";}
function hide(o){document.getElementById(o).style.display="none";}
function geturl(url,id){
var http=false;
$(id).innerHTML='<span class="loading">&nbsp;&nbsp;</span>';
if(window.XMLHttpRequest){http=new XMLHttpRequest();if(http.overrideMimeType){http.overrideMimeType('text/plain');}}else if(window.ActiveXObject){try{http=new ActiveXObject("Msxml2.XMLHTTP");}catch(e){try{http=new ActiveXObject("Microsoft.XMLHTTP");}catch(e){}}}
if(!http){alert('Cannot send an XMLHTTP request');return false;}
http.onreadystatechange=function(){if(http.readyState==4){$(id).innerHTML=http.responseText;}}
http.open("get", url, true);
http.setRequestHeader('Content-Type','application/x-www-form-urlencoded');
http.send(null);
}
function imgsize(){
	var img=document.getElementById("content").getElementsByTagName("img");
	for(var i=0; i<img.length;i++){
		if(img[i].width>imgwidth){img[i].width=imgwidth;img[i].style.width=imgwidth;img[i].title="View";img[i].style.cursor="pointer";img[i].border=0;img[i].onclick=function(e){window.open(this.src);}}
	}
}