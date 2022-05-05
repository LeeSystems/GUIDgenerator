rem convert bitmap file to Icons

convert GUIDicon.png -resize 256x256 -transparent white icon-256.png
convert icon-256.png -resize 16x16 icon-16.png
convert icon-256.png -resize 32x32 icon-32.png
convert icon-256.png -resize 64x64 icon-64.png
convert icon-256.png -resize 128x128 icon-128.png
convert icon-16.png icon-32.png icon-64.png icon-128.png icon-256.png -colors 256 GUIDicon.ico

del icon-256.png
del icon-16.png
del icon-32.png
del icon-64.png
del icon-128.png

rem Icons created
