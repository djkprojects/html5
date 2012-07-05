<?php

function imtest($file) {
  $im = new Imagick($file);
  
  
  $it = $im->getPixelIterator();
  foreach( $it as $row => $pixels )
  {
      foreach ( $pixels as $column => $pixel ) {
        $rgb = $pixel->getColor();
  			$des = desaturate($pix['r'], $pix['g'], $pix['b']);			
        $pixel->setColor('blue');
      }
      $it->syncIterator(); 
  }
  
  /*
  $size = $im->getImageGeometry();
  $width = $size['width'];
  $height = $size['height'];
  
    for ($y = 0; $y < $height; $y++) {	
    	for ($x = 0; $x < $width; $x++) {	
    		  $rgb = $im->getImagePixelColor ($x ,$y );
    		  $des = desaturate($pix['r'], $pix['g'], $pix['b']);			
    		}
    }*/
}

function desaturate($r, $g, $b) {
	
	$max = $r;
	if ($g > $max) $max = $g;
	if ($b > $max) $max = $b;
	
	$min = $r;
	if ($g < $min) $min = $g;
	if ($b < $min) $min = $b;

	return ($min + $max) / 2;
}

function getPixelAt($im, $x, $y) {
	$rgb = imagecolorsforindex($im, imagecolorat($im, $x, $y));
	return array($rgb['red'], $rgb['green'], $rgb['blue'], $rgb['alpha']);
}

function test($file) {

	$im_info = getimagesize($file);
	$im = imagecreatefromjpeg($file);
	
	$width = $im_info[0];
	$height = $im_info[1];
	
	for ($y = 0; $y < $height; $y++) {	
		
		for ($x = 0; $x < $width; $x++) {	
			
			$pix = getPixelAt($im, $x, $y);
			$des = desaturate($pix[0], $pix[1], $pix[2]);
			
			$id = imagecolorallocate($im, $des, $des, $des);
			
			imagesetpixel($im, $x, $y, $id);
		}	
	}

	//imagejpeg($im);
	//imagedestroy($im);	
}

//header('Content-Type: image/jpeg');
$time_start = microtime(true);
test('castle.jpg');
$time_end = microtime(true);

echo $time_end - $time_start;
?>