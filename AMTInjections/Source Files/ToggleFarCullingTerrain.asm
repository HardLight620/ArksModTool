INCLUDE <ASMInclude.asm>
INCLUDE <AMTFlags.asm>

public ToggleFarCullingTerrain
public ToggleFarCullingTerrain_End
public ToggleFarCullingTerrain_Bindings

.DATA

ToggleFarCullingTerrain_Bindings	DWORD		0
bind0								DWORD		b0+2

.CODE

ToggleFarCullingTerrain:
b0:	test byte ptr ds:[NO_ADDRESS], FLAG1_DISABLE_FAR_CULLING
	jne d0
	movss xmm1, [edx+000000CC]
	comiss xmm1, [edi+00000148]
	jna d1
	subsd xmm2, xmm0
	cvtsd2ss xmm1, xmm2
	pxor xmm0, xmm0
	maxss xmm1, xmm0
	movaps dword ptr [esp], xmm1
	mov eax, dword ptr [esp]
	nopx 8
ToggleFarCullingTerrain_End:

d0 = ToggleFarCullingTerrain+76
d1 = ToggleFarCullingTerrain+3A

END