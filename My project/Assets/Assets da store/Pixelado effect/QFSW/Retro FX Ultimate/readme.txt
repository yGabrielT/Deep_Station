Retro FX Ultimate V1.0.0

Thank you for purchasing this asset, I hope it finds you well. If you have any questions, suggestions or problems please contact me at support@qfsw.co.uk
To use the C# API, add using namespace QFSW.RetroFXUltimate to the top of your scripts

1. Retro FX
To begin using, simply add the RetroFX.cs script to your camera. You can change all of the following settings either from the built in inspector, or the C# API
- Match Reference Resolution: Match reference resolution instead of using a resolution percentage.
- Reference Height: The reference height to match after pixelation.
- Resolution Percentage: The percentage of the resolution to pixelate down to.
- Use Palette: Use a predefined color palette.
- Color Palette: The color palette to use.
- Contrast Boost: The amount to boost the contrast by.
- Brightness Boost: The amount to boost the brightness by.
- Color Depth: The number of bits for each color channel.
- Enable Dithering: If dithering should be enabled.
- RGB Dithering: If dithering should be applied to each channel seperately.
- Pixelate Dither Map: If the pixelation should also be applied to the dither map.

Pixelation reduces the effective resolution of the image.
When using a color palette, every pixel in the image will be a color from the palette. This is to mimic the art style of older games caused by hardware limitations.
Dithering is a technique used by old systems to create the illusion of more colors, by alternating pixels between different colors.

2. Color Palette
A color palette can be created by using Create > Retro FX Ultimate > Palette, in the Project view.
Palettes have several presets which can be instantly created by using the buttons in the inspector, or calling their respective C# functions
To create your own palette, simply set the size of the palette (bounded at 128) and choose all of the displayed colors to your liking

3. Increasing Maximum Palette Size
If you would like to change the maximum palette size, simply change the MAX_PALETTE_SIZE constants found inside of Palette.cs and RetroFX.shader