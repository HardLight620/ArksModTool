INCLUDE <ASMInclude.asm>
INCLUDE <AMTFlags.asm>

public ToggleUpdateCulling
public ToggleUpdateCulling_End
public ToggleUpdateCulling_Bindings

.DATA

ToggleUpdateCulling_Bindings	DWORD		0
bind0							DWORD		b0+2
bind1							DWORD		b1+4
bind2							DWORD		b2+4

.CODE

ToggleUpdateCulling:
b0:	test byte ptr ds:[NO_ADDRESS], FLAG1_DISABLE_UPDATE_CULLING
	jne d2
	cvtss2sd xmm1, [edi+000000CC]
	cvtss2sd xmm2, [edi+64]
	comisd xmm1, xmm2
	ja d3
	test al, 04
	jne d0
	test al, 01
	je d1
	test al, 02
	jne d1
d0:
b1:	comisd xmm1, qword ptr ds:[NO_ADDRESS]
	ja d3
d1:	cvtss2sd xmm0, [ebp+1C]
b2:	comisd xmm0, qword ptr ds:[NO_ADDRESS]
	jna d2
	test byte ptr [edi+2D], 04
	jne d3
	comisd xmm1, xmm0
	ja d3
d2:	xor ebx, ebx
	jmp d4
d3:	mov ebx, 00000001
d4:	nop
	nop
ToggleUpdateCulling_End:

END