#include "sh_Utils.h"

varying highp vec2 v_TexCoord;
varying highp vec4 v_TexRect;

void main(void)
{
    highp float hueValue = v_TexCoord.x / (v_TexRect[2] - v_TexRect[0]);
    gl_FragColor = hsv2rgb(vec4(hueValue, 1, 1, 1));
}
