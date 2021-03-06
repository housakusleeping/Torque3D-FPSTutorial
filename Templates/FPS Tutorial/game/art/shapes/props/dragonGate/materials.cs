//-----------------------------------------------------------------------------
// Copyright (c) 2012 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

//--- dragonGate.dae MATERIALS BEGIN ---
singleton Material(dragonGate_dragonGateLOD)
{
	mapTo = "dragonGateLOD";

	diffuseMap[0] = "art/shapes/props/dragonGate/dragonGate_diffuse.dds";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "0.7 0.7 0.7 0";
	specular[0] = "1 1 1 0";
	specularPower[0] = 50;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "132";
   constantCubemapGloss = "0.2";
   materialTag0 = "Untagged";
};

//--- dragonGate.dae MATERIALS END ---


singleton Material(dragonGate_dragonGate)
{
   mapTo = "dragonGate";
   diffuseMap[0] = "art/shapes/props/dragonGate/dragonGate_diffuse.dds";
   normalMap[0] = "art/shapes/props/dragonGate/dragonGate_normals.dds";
   specular[0] = "1 1 1 0";
   specularPower[0] = "1";
   specularMap[0] = "art/shapes/props/dragonGate/dragonGate_specular.dds";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "53";
   materialTag0 = "Untagged";
};
