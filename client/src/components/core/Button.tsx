import { MouseEvent, PropsWithChildren } from "react";

type ButtonProps = {
	onClick?: (e: MouseEvent) => void;
	disabled?: boolean;
	type?: 'button' | 'submit' | 'reset';
	color?: string;
	full?: boolean;
	className?: string;
} & PropsWithChildren;

export const Button = ({
	onClick,
	type,
	disabled,
	color,
	full,
	className,
	children,
}: ButtonProps) => {
	return (
		<button
			className={
				'btn text-base capitalize ' +
				(color ? color + ' ' : 'btn-primary ') +
				(full ? ' w-full' : '') +
				(className ? ' ' + className : '')
			}
			onClick={(e: MouseEvent) => {
				onClick && onClick(e);
			}}
			type={type}
			disabled={disabled}
		>
			{children}
		</button>
	);
};
