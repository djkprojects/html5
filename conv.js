function applyMedian(idata, odata, levels) {
							
	var  i = j = 0, 
		 h = parseInt(idata.height),
		 w = parseInt(idata.width),
		 ms = size = 2 * levels + 1,
		 ms2 = Math.floor(ms/2);
	
		 size *= size;
	
	for (i = 0; i < h; i++) {
		
		for (j = 0; j < w; j++) {

			var r = g = b = cc = 0;

			/*if (size != 9) {

				var tl = tc = tr = cl = cc = cr = bl = bc = br = 0;
							
				cc = i * w + j;
				cl = (j == 0)?cc:cc - 1;
				cr = (j ==w - 1)?cc:cc + 1;

				tc = (i == 0)?cc:cc - w;
				tl = (j == 0)?tc:tc - 1;
				tr = (j == w - 1)?tc:tc + 1;

				bc = (i == h - 1)?cc:cc + w;
				bl = (j == 0)?bc:bc - 1;
				br = (j == w - 1)?bc:bc + 1;
										
				cc *= 4; cl *= 4; cr *= 4; tc *= 4; tl *= 4; tr *= 4; bc *= 4; bl *= 4; br *= 4;

				r = (idata.data[tl] * kernel[0]) + (idata.data[tc] * kernel[1]) + (idata.data[tr] * kernel[2]) +
   					(idata.data[cl] * kernel[3]) + (idata.data[cc]  * kernel[4]) + (idata.data[cr] * kernel[5]) +
					(idata.data[bl] * kernel[6]) + (idata.data[bc] * kernel[7]) + (idata.data[br] * kernel[8]);

				g = (idata.data[tl + 1] * kernel[0]) + (idata.data[tc + 1] * kernel[1]) + (idata.data[tr + 1] * kernel[2]) +
   					(idata.data[cl + 1] * kernel[3]) + (idata.data[cc + 1]  * kernel[4]) + (idata.data[cr + 1] * kernel[5]) +
   					(idata.data[bl + 1] * kernel[6]) + (idata.data[bc + 1] * kernel[7]) + (idata.data[br + 1] * kernel[8]);

				b = (idata.data[tl + 2] * kernel[0]) + (idata.data[tc + 2] * kernel[1]) + (idata.data[tr + 2] * kernel[2]) +
   					(idata.data[cl + 2] * kernel[3]) + (idata.data[cc + 2]  * kernel[4]) + (idata.data[cr + 2] * kernel[5]) +
   					(idata.data[bl + 2] * kernel[6]) + (idata.data[bc + 2] * kernel[7]) + (idata.data[br + 2] * kernel[8]);					

			}
			else {*/
			
				var m = x = y = pos = 0;
				var rt = [], gt = [], bt = [];

				for (m = 0;  m < size; m++) {
										
					x = j - ms2 + (m % ms);
					y = i - ms2 + Math.floor(m/ms);
					
					if (x < 0) x = 0;
					else if (x > w - 1) x = w - 1;
					
					if (y < 0) y = 0;
					else if (y > h -1) y = h - 1;
										
					pos = (y * w + x) * 4;
										
					rt[m]=idata.data[pos];
					gt[m]=idata.data[pos + 1];			
					bt[m]=idata.data[pos + 2];
				}
				
				rt.sort(array_sort);
				gt.sort(array_sort);				
				bt.sort(array_sort);		
				
				r = rt[rt.length/2>>0];
				g = gt[gt.length/2>>0];
				b = bt[bt.length/2>>0];
									
				cc = (i * w + j) * 4;
		   //}
		   
		   odata.data[cc] = r;
		   odata.data[cc+1] = g;
		   odata.data[cc+2] = b;	   				
		}
	}
	return odata;
}

function array_sort(a,b){return a-b}