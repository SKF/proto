python -m pip install virtualenv
virtualenv build/venv
source build/venv/bin/activate

for SERVICE in $SERVICES; do
  mkdir -p build/python/$SERVICE;
  python -m grpc_tools.protoc \
    -I $SERVICE \
    --python_out build/python/$SERVICE \
    --grpc_python_out build/python/$SERVICE $SERVICE/*.proto;
done