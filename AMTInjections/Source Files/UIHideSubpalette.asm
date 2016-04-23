INCLUDE <ASMInclude.asm>
INCLUDE <AMTFlags.asm>

public UIHideSubpalette
public UIHideSubpalette_End
public UIHideSubpalette_Bindings

.DATA

UIHideSubpalette_Bindings	DWORD		0
bind0						DWORD		b0+2
bind1						DWORD		b1+2
bind2						DWORD		b2+2
bind3						DWORD		b3+2
bind4						DWORD		b4+2

.CODE

UIHideSubpalette:
b0:	test byte ptr ds:[NO_ADDRESS], FLAG0_HIDE_SUBPALETTE
	je d0
	xor esi, 01
d0:	xor ecx, ecx
	xor edx, edx
	test ebp, ebp
	je d1
b1:	cmp dword ptr [ebp+00001B80], 00
	je d1
b2:	mov ecx, [ebp+00000700]
	not ecx
	shr ecx, 07
	and ecx, 01
d1:
b3:	mov ebp, ds:[NO_ADDRESS]
	test ebp, ebp
	je d2
	mov ebp, [ebp+04]
	jmp d3
d2:	xor ebp, ebp
d3:	test esi, esi
	jne d4
	test eax, eax
	je d4
	test ecx, ecx
	jne d4
	test ebp, ebp
	je d5
d4:	or edx, 01
d5:	mov eax, edx
b4:	cmp dword ptr[ebx+70], 00
	jne d6
	xor edx, 01
d6:	test edx, edx
	jne d7
	nopx 0B
UIHideSubpalette_End:

d7 = UIHideSubpalette+1B0

END