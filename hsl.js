function rgb2hsl(red,green,blue){
		   var r = red, g = green, b = blue;
		   var h, s, l;
		   var min, max;
		   var delta;

		   if (r > g){
		      max = Math.max (r, b);
		      min = Math.min (g, b);
		   }else{
		      max = Math.max (g, b);
		      min = Math.min (r, b);
		   }

		   l = (max + min) / 2.0;

		   if (max == min){
		      s = 0.0;
		      h = 0.0;
		   }else{
		      delta = (max - min);

		      if (l < 128){
		         s = 255 * delta / (max + min);
		      }else{
		         s = 255 * delta / (511 - max - min);
		      }
		      if (r == max){
		         h = (g - b) / delta;
		      }else if (g == max){
		         h = 2 + (b - r) / delta;
		      }else{
		         h = 4 + (r - g) / delta;
		      }

		      h = h * 42.5;

		      if (h < 0){ h += 255; }
		      else if (h > 255){ h -= 255; }
		   }

		   return [Math.round(h), Math.round(s), Math.round (l)];
		}

		function hsl2rgb(hue,saturation,lightness){
		   var h = hue, s = saturation, l = lightness;

		   if (s == 0){
		      /*  achromatic case  */
		      hue        = l;
		      lightness  = l;
		      saturation = l;
		   }else{
		      var m1, m2;

		      if (l < 128){
		         m2 = (l * (255 + s)) / 65025.0;
		      }else{
		         m2 = (l + s - (l * s) / 255.0) / 255.0;
		      }
		      m1 = (l / 127.5) - m2;

		      /*  chromatic case  */
		      hue        = hslValue (m1, m2, h + 85);
		      saturation = hslValue (m1, m2, h);
		      lightness  = hslValue (m1, m2, h - 85);
		   }

		   return [hue, saturation, lightness];
		};

		function hslValue(n1,n2,hue){
		   var value;

		   if (hue > 255){ hue -= 255; }
		   else if (hue < 0) { hue += 255; }

		   if (hue < 42.5){
		      value = n1 + (n2 - n1) * (hue / 42.5);
		   }else if (hue < 127.5){
		      value = n2;
		   }else if (hue < 170){
		      value = n1 + (n2 - n1) * ((170 - hue) / 42.5);
		   }else{
		      value = n1;
		   }
		   return Math.round(value * 255.0);
		};
