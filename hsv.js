function hsl(r, g, b, hue, sat, lit, col) {
	
	var r = r / 255,
		g = g / 255,
		b = b / 255;
	
	if (hue != 0 || sat != 0 || col == 1) {
		
		// Math.max/min seem slower
		var max = r;
		if (g > max) max = g;
		if (b > max) max = b;
		
		var min = r;
		if (g < min) min = g;
		if (b < min) min = b;
		
		var c = max - min;
		var l = (max + min) / 2;
		
		if (col) {
			
			r = g = b = l;

			// saturation
			var s = (sat > 100)?100:(sat < 0)?0:sat;
			s /= 100;
					
			// hue
			var h = (hue > 360)?1:(hue<-360)?-1:hue/360;
			h *= 6;
			
			if (l <= 0.5) {
				var cm = l + l * s;
			}
			else {
				var cm = l + (1 - l) * s;
			}
		}		
		else if (c > 0 && l > 0) {
			
			// saturation
			var s = (sat > 100)?100:(sat < -100)?-100:sat;
			
			if (s < 0) s = 0.01*s + 1;
			else if (s > 0) s = s/(-0.01*s*s + s);
			else s = 1;
						
			if (l <= 0.5) {
				s *= c / (min + max); //c/2L
				if (s > 1) s = 1;
				var cm = l * (1 + s);
			}
			else {
				s *= c / (2 - max - min); // c/(2 - 2L)
				if (s > 1) s = 1;
				var cm = (l + s - l * s);
			}
			
			/*var arr = [157, 156, 156, 155, 154, 154, 153, 153, 152, 151];
			
		    for (var i = 0; i < arr.length; i++) {
			    var lvl = (i+1)*10;
		    	var s2 = (((arr[i]/255 - l)*(2 - max - min))/((1 - l)*c));
			    console.log(lvl + ' ' + arr[i] + ' ' + s2);
		    }*/
		    
			// hue
			var h = (hue > 180)?0.5:(hue<-180)?-0.5:hue/360;
			h *= 6;
				
		    if (r == max) h += (g - b) / c + (g < b ? 6 : 0);
		    else if (g == max) h += (b - r) / c + 2;
		    else h += (r - g) / c + 4;
		}
		
		if (typeof cm != undefined) {
		
			if (h < 0) h += 6;
			else if (h >= 6) h -= 6;
		
		    var hi = h>>0;
		    var m = l + l - cm;
		       
		    if (hi == 0) {
			    r = cm; g = m + (cm - m) * (h - hi); b = m;
		    }
		    else if (hi == 1) {   
			    r = cm - (cm - m) * (h - hi); g = cm; b = m;	    
		    }
		    else if (hi == 2) {
			    r = m; g = cm; b = m + (cm - m) * (h - hi);
		    }
		    else if (hi == 3) {
			    r = m; g = cm - (cm - m) * (h - hi); b = cm;
		    }
		    else if (hi == 4) {
			    r = m + (cm - m) * (h - hi); g = m; b = cm;
		    }
		    else if (hi == 5) {
			    r = cm; g = m; b = cm - (cm - m) * (h - hi);
		    }
	    }
    }
        
	// lightness
	var l = lit / 100;
        
    if (l < 0) {
        var l1 = l + 1;
	    r *= l1; g *= l1; b *= l1;	    
    }
    else if (l > 0) {
    	var l1 = 1 - l;
	    r = r * l1 + l; g = g * l1 + l; b = b * l1 + l;
    }
    
    //console.log(s + ' ' + c + ' ' + l + ' ')    ;
    //console.log(r*255 + ' ' + g*255 + ' ' + b*255 + ' [h: ' + h + ' hi: ' + hi + ' l: ' + l  +' s: ' + s + ']')
    
    return [r * 255, g * 255, b * 255];
}