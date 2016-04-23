INCLUDE <ASMInclude.asm>
INCLUDE <AMTFlags.asm>

public ToggleFarCulling
public ToggleFarCulling_End
public ToggleFarCulling_Bindings

.DATA

ToggleFarCulling_Bindings	DWORD		0
bind0						DWORD		b0+2

.CODE

ToggleFarCulling:
	test byte ptr[esi+1B], 20
	je d0
	mov eax, [esi+28]
	mov edx, [esi+2C]
	test edx, 00180000
	jne d1
d0:	jmp d3
d1:	test edx, 00080000
	je d4
b0:	test byte ptr ds:[NO_ADDRESS], FLAG1_DISABLE_FAR_CULLING
	jne d4
	movss xmm1, [esi+60]
	test al, 80
	jne d2
	movss xmm1, [esi+64]
d2:	nop
	nop
ToggleFarCulling_End:

d3 = ToggleFarCulling+266
d4 = ToggleFarCulling+4C

END