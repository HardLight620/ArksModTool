INCLUDE <ASMInclude.asm>
INCLUDE <AMTFlags.asm>

public ColorAdjustments
public ColorAdjustments_End
public ColorAdjustments_Bindings

.DATA

ColorAdjustments_Bindings	DWORD		0
bind0						DWORD		b0+1
bind1						DWORD		b1+2
bind2						DWORD		b2+3
bind3						DWORD		b3+1

.CODE

ColorAdjustments:
	push edi
	push esi
	push ebx
	sub esp, 4
b0:	mov esi, NO_ADDRESS
	test byte ptr[esi+02], FLAG2_OVERRIDE_COLORS
	je d0
b1:	mov ebx, ds:[NO_ADDRESS]
	lea edi, [ebx+10]
	mov ecx, edi
b2:	mov DWORD PTR [esp], NO_ADDRESS
	push esp
b3:	call NO_SYMBOL
	cmp eax, edi
	je d0
	mov ecx, [eax+28]
	mov edx, [ebx+04]
	mov eax, [ebx+08]
	sub eax, edx
	sar eax, 02
	cmp eax, ecx
	jbe d0
	mov ecx, [edx+ecx*4]
	mov eax, [esi+50]
	mov [ecx+50], eax
	mov eax, [esi+54]
	mov [ecx+54], eax
	mov eax, [esi+58]
	mov [ecx+58], eax
	movaps xmm0, [esi+60]
	movaps [ecx+60], xmm0
d0:	add esp, 4
	pop ebx
	pop esi
	pop edi
	ret
ColorAdjustments_End:

END