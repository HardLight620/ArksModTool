INCLUDE <ASMInclude.asm>
INCLUDE <AMTFlags.asm>

public UIHideMenus
public UIHideMenus_End
public UIHideMenus_Bindings

.DATA

UIHideMenus_Bindings	DWORD		0
bind0					DWORD		b0+2

.CODE

UIHideMenus:
	add esp, 10
b0:	test byte ptr ds:[NO_ADDRESS], FLAG0_HIDE_ALL_UI
	jne d0
	push ebp
	push 00
	push 3F800000
	push esi
	mov ecx, [edi+20]
	nop
	nop
UIHideMenus_End:

d0 = UIHideMenus+1F

END