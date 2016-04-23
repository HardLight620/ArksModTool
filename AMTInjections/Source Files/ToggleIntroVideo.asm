INCLUDE <ASMInclude.asm>
INCLUDE <AMTFlags.asm>

public ToggleIntroVideo
public ToggleIntroVideo_End
public ToggleIntroVideo_Bindings

.DATA

ToggleIntroVideo_Bindings	DWORD		0
bind0						DWORD		b0+2
bind1						DWORD		b1+1
bind2						DWORD		b2+2
bind3						DWORD		b3+1

.CODE

ToggleIntroVideo:
	je d0
b0:	mov ecx, ds:[NO_ADDRESS]
b1:	mov eax, NO_ADDRESS
b2:	test byte ptr ds:[NO_ADDRESS], FLAG0_DISABLE_INTRO
	je d1
	add eax, 50
d1:	push eax
b3:	call NO_SYMBOL
d0:	ret 0004
	nop
ToggleIntroVideo_End:

END