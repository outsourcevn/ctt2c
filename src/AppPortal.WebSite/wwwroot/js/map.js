var map;
var gl_station;
var gl_selected_station;
var gl_station_label;
var gl_island_label;
var station_clicked = true;

require(["esri/map", "esri/geometry/Point", "esri/symbols/SimpleMarkerSymbol", "esri/symbols/TextSymbol", "esri/symbols/Font", "esri/graphic", "esri/layers/GraphicsLayer", "dojo/_base/array", "esri/Color", "esri/geometry/webMercatorUtils", "dojo/dom", "dojo/domReady!"], 
function(Map, Point, SimpleMarkerSymbol, TextSymbol, Font, Graphic, GraphicsLayer, arrayUtils, Color, webMercatorUtils, dom) {
  map = new Map("esrimap", {
	basemap: "topo",
	center: [106, 18],
	zoom: 5
  });
  map.on("load", DisplayStationsOnMap);
  map.on("zoom-end", TurnOnOffGraphicLayerOnMap);
  map.on("mouse-move", showCoordinates);
    map.on("mouse-out", hideCoordinates);
  
function DisplayStationsOnMap()
{
	gl_island_label = new GraphicsLayer();			
	map.addLayer(gl_island_label);	
	gl_selected_station = new GraphicsLayer();			
	map.addLayer(gl_selected_station);			
	gl_station = new GraphicsLayer();			
	map.addLayer(gl_station);
	gl_station.on("click", gl_station_Clicked);
	gl_station_label = new GraphicsLayer();			
	map.addLayer(gl_station_label);
	
	$.ajax({
		method: "GET",
        url: "http://envisoft.gov.vn/eos/services/call/json/get_stations?qi_type=aqi",
		success: function (data, status) {
			if (data.success == true) {
				var dulieu = data.stations;
				for (var i = 0; i < dulieu.length; i++) {
					if (dulieu[i].qi > 0) {
						//Tram.push(dulieu[i]);
						var qi = dulieu[i].qi;
						var station_name = dulieu[i].station_name;
						var station_id = dulieu[i].id;
						var station = new Point();								
						//station.x = dulieu[i].latitude;
						//station.y = dulieu[i].longitude;
                        station.x = dulieu[i].longitude;
                        station.y = dulieu[i].latitude;
						if (station_name == "Hoàng Mai")
						{
							station.x = 105.87;
							station.y = 20.975;	
						}
						if (station_name == "Ninh Bình")
						{
							station.x = 105.941;
							station.y = 20.245;								
						}
						if (station_name == "Trạm Nguyễn Văn Cừ (KK)")
						{
							station.x = 105.885;
							station.y = 21.05;								
						}
						if (station_name == "Uông Bí")
						{
							station.x = 106.8;
							station.y = 21.05;								
						}
						//alert(station.x + "," + station.y + "," + dulieu[i].qi);
						var markerSymbol = new SimpleMarkerSymbol();
						if (qi <= 50)
							markerSymbol.setColor(new Color("#008000"));
						else if (qi > 50 && qi <= 100)
							markerSymbol.setColor(new Color("#FFFF00"));
						else if (qi > 100 && qi <= 200)
							markerSymbol.setColor(new Color("#099099"));
						else if (qi > 200 && qi <= 300)
							markerSymbol.setColor(new Color("#FF0000"));
						else if (qi > 300)
							markerSymbol.setColor(new Color("#800080"));
						markerSymbol.setSize("16");								
						var graphic_station = new Graphic(station, markerSymbol);
						//graphic_station.setAttributes({"lat":station.x,"long":station.y,"name":station_name});
						graphic_station.setAttributes({"station_id":station_id,"station_name":station_name});
						gl_station.add(graphic_station);								
						
						//alert(station_name);
						var initColor = "#0000EE";
						var font  = new Font();
						font.setSize("10pt");
						font.setWeight(Font.WEIGHT_BOLD);
						font.setFamily("tahoma");
						var textSymbol = new TextSymbol(station_name);				
						textSymbol.setColor(initColor);
						textSymbol.setAlign(TextSymbol.ALIGN_START);
						textSymbol.setAngle(0);
						textSymbol.setFont(font);
						textSymbol.setOffset(8,8);
						textSymbol.setHaloColor(new Color([255, 255, 255, 1]));
						textSymbol.setHaloSize(2);
						var graphic_station_label = new Graphic(station,textSymbol);
						gl_station_label.add(graphic_station_label);								
					}
				}
			} else {
				alert("Lỗi API. Xin vui lòng kiểm tra lại!");
			}
		},
		error: function () {
			alert("Lỗi API. Xin vui lòng kiểm tra lại!");
		}
	});
	DisplayIslandsLabelOnMap();
}

function DisplayIslandsLabelOnMap()
{
	var points = [[112,16.34],[112,8.6]];
	var labels = ["Hoàng Sa","Trường Sa"];
	var initColor = "#719DB1";
	var font  = new Font();
	font.setSize("9pt");
	font.setFamily("tahoma");
	//font.setWeight(Font.WEIGHT_BOLD);			
	for (var i = 0; i < points.length; i++)
	{
		var point = new Point(points[i]);
		//alert(point.x);
		var textSymbol = new TextSymbol(labels[i]);				
		textSymbol.setColor(initColor);
		textSymbol.setAlign(TextSymbol.ALIGN_MIDDLE);
		textSymbol.setAngle(0);
		textSymbol.setFont(font);
		textSymbol.setOffset(0,0);
		var gra_label = new Graphic(point,textSymbol);
		gl_island_label.add(gra_label);		
		
	}	
}

function TurnOnOffGraphicLayerOnMap()
{
	var zoomlevel = map.getZoom();
	if (zoomlevel < 3)
		gl_island_label.hide();
	else
		gl_island_label.show();
		
	if (zoomlevel < 4)
	{	
		gl_station.hide();
		gl_selected_station.hide();
	}
	else
	{	
		gl_station.show();
		gl_selected_station.show();
	}	
	if (zoomlevel < 5)
	{
		gl_station_label.hide();
	}
	else			
		gl_station_label.show()				
}

function ZoomToSelectedStation(station_name)		
{
	gl_selected_station.clear();
	$.ajax({
		method: "GET",
        url: "http://envisoft.gov.vn/eos/services/call/json/get_stations?station_name=" + station_name + "&is_qi=True",
		success: function (data, status) {
		if (data.success == true) 
		{
			var dulieu = data.stations[0];
			var station = new Point();							
			//station.x = dulieu.latitude;
   //         station.y = dulieu.longitude;
            station.x = dulieu.longitude;
            station.y = dulieu.latitude;
			if (station_name == "Hoàng Mai")
			{
				station.x = 105.87;
				station.y = 20.975;	
			}
			if (station_name == "Ninh Bình")
			{
				station.x = 105.941;
				station.y = 20.245;								
			}
			if (station_name == "Trạm Nguyễn Văn Cừ (KK)")
			{
				station.x = 105.885;
				station.y = 21.05;								
			}
			if (station_name == "Uông Bí")
			{
				station.x = 106.8;
				station.y = 21.05;								
			}
			//alert(station.x + "," + station.y + "," + station_name);
			var markerSymbol = new SimpleMarkerSymbol();
			markerSymbol.setColor("#EFA216");
			markerSymbol.outline.setColor("#EFA216");
			markerSymbol.setSize("24");								
			var graphic_selected_station = new Graphic(station, markerSymbol);
			//graphic_selected_station.setAttributes({"lat":station.x,"long":station.y,"name":station_name});
			gl_selected_station.add(graphic_selected_station);
			if (station_clicked == false)
				map.centerAndZoom(station,10);
			else
				station_clicked = false;
		} else {
				alert("Lỗi API. Xin vui lòng kiểm tra lại!");
			}
		},
		error: function () {
			alert("Lỗi API. Xin vui lòng kiểm tra lại!");
		}
	});
	
}
window.ZoomToSelectedStation = ZoomToSelectedStation;

function gl_station_Clicked(evt)
{
	station_clicked = true;
	var station_id = evt.graphic.attributes.station_id;
	$("#listTram").val(station_id);
	$("#listTram").change();	
}

function showCoordinates(evt) 
{
	var mp = webMercatorUtils.webMercatorToGeographic(evt.mapPoint);
	dom.byId("info").innerHTML = "<b>Long: </b>" + mp.x.toFixed(3) + "<b>, Lat: </b>" + mp.y.toFixed(3);
}
function hideCoordinates(evt) 
{   
	//hide mouse coordinates
	dom.byId("info").innerHTML = "";
}
});