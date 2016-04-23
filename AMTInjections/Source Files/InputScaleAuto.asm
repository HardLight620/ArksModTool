INCLUDE <ASMInclude.asm>

public InputScaleAuto
public InputScaleAuto_End
public InputScaleAuto_Bindings

.DATA

InputScaleAuto_Bindings	DWORD		0
bind0					DWORD		b0+4
bind1					DWORD		b1+4
bind2					DWORD		b2+4

.CODE

InputScaleAuto:
	mov ecx, esi
	mov dword ptr[esp], 3F800000
	movss xmm3, dword ptr [esp]
b0:	mulss xmm3, dword ptr ds:[NO_ADDRESS]
b1:	minss xmm3, dword ptr ds:[NO_ADDRESS]
b2:	maxss xmm3, dword ptr ds:[NO_ADDRESS]
	shufps xmm3, xmm3, 45
	pxor xmm2, xmm2
	subps xmm2, xmm3
	mov edx, [ebp+08]
	movaps [edx], xmm2
	nop
	nop
InputScaleAuto_End:

END