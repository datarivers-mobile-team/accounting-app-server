import { Outlet } from 'react-router-dom';

export const AuthLayout = () => {
	return (
		<div className="flex items-center justify-between flex-row-reverse w-screen h-screen">
			<Outlet />
		</div>
	);
};
