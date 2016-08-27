INCLUDE <ASMInclude.asm>

public InputScaleNormal
public InputScaleNormal_End
public InputScaleNormal_Bindings

.DATA

InputScaleNormal_Bindings	DWORD		0
bind0						DWORD		b0+4
bind1						DWORD		b1+4
bind2						DWORD		b2+4

.CODE

InputScaleNormal:
	movaps xmm2, xmm0
	movaps xmm3, xmm0
	movaps xmm4, xmm0
	shufps xmm2, xmm0, 00
	shufps xmm3, xmm0, 55
	shufps xmm4, xmm0, 0AA
	addps xmm2, xmm4
	addps xmm2, xmm3
	sqrtps xmm2, xmm2
	movss xmm3, xmm2
b0:	mulss xmm3, dword ptr ds:[NO_ADDRESS]
b1:	minss xmm3, dword ptr ds:[NO_ADDRESS]
b2:	maxss xmm3, dword ptr ds:[NO_ADDRESS]
	shufps xmm3, xmm3, 00
	divps xmm1, xmm2
	mulps xmm1, xmm3
	mov eax, [ebp+8]
	movaps [eax], xmm1
	nopx 21
InputScaleNormal_End:

END