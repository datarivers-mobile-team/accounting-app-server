import { AuthLayout } from 'layouts';
import { Route, Routes } from 'react-router-dom';
import LoginPage from './login';

const AuthRouter = () => {
	return (
		<Routes>
			<Route path="/" element={<AuthLayout />}>
				<Route path="login" element={<LoginPage />} />
			</Route>
		</Routes>
	);
};

export default AuthRouter;