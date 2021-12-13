# Generated by Django 3.1.3 on 2021-10-26 02:20

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('main', '0003_auto_20211020_1813'),
    ]

    operations = [
        migrations.CreateModel(
            name='UserBodega',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('id_bodega', models.IntegerField()),
            ],
        ),
        migrations.CreateModel(
            name='UserCliente',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('id_cliente', models.IntegerField()),
            ],
        ),
        migrations.CreateModel(
            name='UserCocina',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('id_cocina', models.IntegerField()),
            ],
        ),
        migrations.CreateModel(
            name='UserFinanzas',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('id_finanzas', models.IntegerField()),
            ],
        ),
        migrations.RemoveField(
            model_name='facturaxxi',
            name='cliente_xxi_id_cliente',
        ),
        migrations.AddField(
            model_name='facturaxxi',
            name='nom_proveedor',
            field=models.CharField(max_length=100, null=True),
        ),
        migrations.AlterField(
            model_name='proveedoresxxi',
            name='nombre_proveedor',
            field=models.CharField(max_length=50),
        ),
    ]
